using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Repositories.Cache;
using Repositories.Cache.Models;
using Services.Cache;
using Services.Serialization.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace Services.Serialization
{
    //this class deals with all serialzation needed to edit and store json as binary in the db
    public class SerializationService : ISerializationService
    {
        private ICacheService _cacheService;
        private ICacheRepository _cacheRepository;
        public SerializationService(ICacheService cacheService, ICacheRepository cacheRepository)
        {
            _cacheService = cacheService;
            _cacheRepository = cacheRepository;
        }
        public ViewJsonDataProperties RetrieveProperties(byte[] jsonList)
        {
            var item = Decompress(jsonList);
            var finalList = DeserializeProperties(item);
            var jsonArray = JArray.Parse(item);
            var model = new ViewJsonDataProperties { Items = finalList, TotalCountOfItems = jsonArray.Count };
            return model;
        }

        public JsonItems RetrieveJsonObject(int itemNumber, byte[] jsonList, int propsCount)
        {
            var item = Decompress(jsonList);
            var finalDictionairy = DeserializeSingleObjectItem(item, itemNumber, propsCount);
            var final = new JsonItems() { ItemNumber = itemNumber, Items = finalDictionairy };
            return final;
        }

        public void UpdateJsonObject(EditJsonItem model)
        {
            var final = new UpdateCacheItemAccessObj();
            var byteCode = _cacheService.GetAll(model.CacheKey).SingleOrDefault(x => x.Key == model.CacheKey).Value; //REFACTOR LATER !!!!!
            var decompressed = Decompress(byteCode);
            var allItems = DeserializeWholeObject(decompressed, model.JsonPropCount);
            var editedItems = EditJson(model, allItems);

            var serializedItems = Serialize(editedItems);
            var compressedItems = Compress(serializedItems);
            final.Key = model.CacheKey;
            final.Value = compressedItems;
            _cacheRepository.UpdateBytesValue(final);
        }

        public List<Dictionary<string, string>> EditJson(EditJsonItem model, List<Dictionary<string, string>> items)
        {
            var currentItem = items[model.CacheItemNumber];
            foreach (var current in model.Items)
            {
                var jsonCurrent = currentItem.SingleOrDefault(x => x.Key == current.Key);
                currentItem[jsonCurrent.Key] = current.Value;
            }
            return items;
        }

        //this is used when we need to deserialize json into a complete, whole form
        public List<Dictionary<string, string>> DeserializeWholeObject(string decompressedValue, int propsCount)
        {
            var finalList = new List<Dictionary<string, string>>();
            var jsonArray = JArray.Parse(decompressedValue);

            for (int i = 0; i < jsonArray.Count; i++)
            {
                finalList.Add(DeserializeSingleObjectItem(decompressedValue, i, propsCount));
            }
            return finalList;
        }

        //this is used to deserialize an individual json item, which is a part of the complete, whole form
        public Dictionary<string, string> DeserializeSingleObjectItem(string decompressedValue, int itemNumber, int propsCount)
        {
            var finalDictionary = new Dictionary<string, string>();
            var jsonArray = JArray.Parse(decompressedValue);
            var currentItem = jsonArray[itemNumber];
            for (int j = 0; j < propsCount; j++)
            {
                var currentJsonProperty = currentItem.Children<JProperty>().ToArray()[j];
                string key = currentJsonProperty.Name;
                string value = (string)currentJsonProperty.Value;
                finalDictionary.Add(key, value);
            }
            return finalDictionary;
        }

        //this is used to deserialize any property names that a json array or dictionairy might have
        public List<string> DeserializeProperties(string decompressedValue)
        {
            var jsonArray = JArray.Parse(decompressedValue);
            var jsonProps = jsonArray.First().ToObject<Dictionary<string, string>>().Select(x => x.Key).ToList();
            return jsonProps;
        }

        public T Deserialize<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        public string Serialize<T>(T items)
        {
            return JsonConvert.SerializeObject(items, Formatting.Indented);
        }

        public string Decompress(byte[] compressedText)
        {
            byte[] gzBuffer = compressedText;

            using (var compressedStream = new MemoryStream(gzBuffer))
            using (var zipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
            using (var resultStream = new MemoryStream())
            {
                zipStream.CopyTo(resultStream);
                return Encoding.UTF8.GetString(resultStream.ToArray());
            }
        }

        public byte[] Compress(string item)
        {
            byte[] input = Encoding.UTF8.GetBytes(item);
            using (var result = new MemoryStream())
            {
                using (var compressionStream = new GZipStream(result,
                    CompressionMode.Compress))
                {
                    compressionStream.Write(input, 0, input.Length);
                    compressionStream.Flush();

                }
                return result.ToArray();
            }
        }
    }
}
