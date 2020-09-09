using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace Services.Serialization
{
    public class SerializationManager : ISerializationManager
    {
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
