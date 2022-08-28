using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    internal static class ClassesCloneMachine
    {
        public static T Clone<T>(this T i_ToClone) where T : class
        {
            using (Stream stream = new MemoryStream())
            {
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(stream, i_ToClone);
                stream.Flush();
                stream.Seek(0, SeekOrigin.Begin);
                T clone = serializer.Deserialize(stream) as T;
                return clone;
            }
        }
    }
}
