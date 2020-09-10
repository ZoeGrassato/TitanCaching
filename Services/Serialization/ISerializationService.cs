using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Serialization
{
    public interface ISerializationService
    {
        string Decompress(byte[] compressedText);
        byte[] Compress(string item);
        T Deserialize<T>(string value);
        string Serialize<T>(T items);
    }
}
