using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace cafe
{
    [Serializable]
    public class Collection<T> : IEnumerable, IEnumerator
    {
        private List<T> objects = new List<T>();
        [NonSerialized]
        int position = -1;
        public List<T> Objects
        {
            get { return objects; }
            set { objects = value; }
        }
        public IEnumerator GetEnumerator()
        {
            return objects.GetEnumerator();
        }

        public object Current
        {
            get
            {
                if (position == -1 || position >= objects.Count)
                    throw new InvalidOperationException();
                return objects[position];
            }
        }

        public bool MoveNext()
        {
            if (position < objects.Count - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public void serializateInFile(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, objects);
                Console.WriteLine("Объекты сериализованы");
            }
        }

        public List<T> deserializateFromFile(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {

                    List<T> newObjects = (List<T>)formatter.Deserialize(fs);


                    Console.WriteLine("Объект десериализован");

                    return newObjects;
                }
            }
            catch (FileNotFoundException) {

            }
            catch(System.Runtime.Serialization.SerializationException) {

            }
            return new List<T>();

        }

        public void Add(T value)
        {
            objects.Add(value);
        }
    }
}
