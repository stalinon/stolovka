using System;

namespace cafe
{
    public enum Education
    {
        Среднее,
        Бакалавр,
        Специалист,
        Магистр
    }

    public enum Function
    {
        Охранник,
        Повар,
        Курьер,
        Менеджер,
        Кассир
    }
    [Serializable]
    public class Employee : Person
    {
        protected Education education;
        protected double salary;
        protected Function function;

        public Education Education { get { return education; } set { education = value; } }
        public double Salary { get { return salary; } set { salary = value; } }
        public Function Function { get { return function; } set { function = value; } }

        public Employee(string name, string surname, DateTime date, double salary, Education education, Function function) : base(name, surname, date)
        {
            this.education = education;
            this.salary = salary;
            this.function = function;
        }

        public override string ToString()
        {
            return name + " " + surname + " " + date.Day + "/" + date.Month + "/" + date.Year + " " + salary + " " + education.ToString() + " " + function.ToString();
        }
    }
}
