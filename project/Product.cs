using System;
namespace cafe
{
    public enum Clasification
    {
        Салаты,
        Первое,
        Второе,
        Гарниры,
        Напитки,
        Прочее
    }
    [Serializable]
    public class Product
    {
        protected int id;
        protected double price;
        protected string name;
        protected Clasification clasification;

        public int Id { get { return id; } }
        public double Price { get { return price; } set { price = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Clasification Clasification { get { return clasification; } set { clasification = value; } }

        public Product(string name, int id, double price, Clasification clasification)
        {
            this.id = id;
            this.price = price;
            this.name = name;
            this.clasification = clasification;
        }

        public override string ToString()
        {
            return name + " " + id + "" + price + " " + clasification.ToString();
        }
    }
}
