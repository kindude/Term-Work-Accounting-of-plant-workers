using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kursach
{
  class Serialize
    {

        public static void SerializeObject(Object newObject, string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, newObject);
            }
        }
        public static Factory DeserializeObject(string filePath)
        {
            Factory newFactory = null;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                try
                {
                    newFactory = (Factory)formatter.Deserialize(fs);
                    
                }
                catch (System.Runtime.Serialization.SerializationException) { }
                return newFactory;
            }
        }
    }
}
