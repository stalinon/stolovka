using System;

namespace cafe
{
    [Serializable]
    public class Person
    {
        protected string name;
        protected string surname;
        protected DateTime date;

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public DateTime Date { get { return date; } set { date = value; } }

        protected Person(string name, string surname, DateTime date)
        {
            this.name = name;
            this.surname = surname;
            this.date = date;
        }
    }
}
