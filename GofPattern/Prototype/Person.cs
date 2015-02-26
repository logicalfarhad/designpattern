using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Prototype
{
    [Serializable]
    public class Person : ICloneable
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public Address Address { get; set; }

        public Person()
        {
            Address = new Address();
        }

        public Object Clone()
        {
            using (Stream stream = new MemoryStream())
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, new Person());
                stream.Seek(0, SeekOrigin.Begin);
                return (Person)binaryFormatter.Deserialize(stream);
            }
        }
    }
    public interface IClone
    {
        Object Clone();
    }
}
