using System;

namespace cafe
{
    public class Client : Person
    {
        protected double check;

        public double Check { get { return check; } set { check = value; } }

        public Client(string name, string surname, DateTime date, double check) : base(name, surname, date)
        {
            this.check = check;
        }

        public override string ToString()
        {
            return name + " " + surname + " " + date.Day + "/" + date.Month + "/" + date.Year + " " + check;
        }
    }
}
