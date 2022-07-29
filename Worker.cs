using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    [Serializable]
    public class Worker
    {
        private string surname;
        private string name;
        private string lastname;
        public int Rank { get; set; }
        public int TableNumber { get; set; }
        public List<Wage> Wages { get; set; }
        static int i = 0;
        static Random rnd = new Random();
        public Worker()
        {
            i += 1;
            Wages = new List<Wage>();
            this.surname = "Иванов";
            this.name = "Иван";
            this.lastname = "Иванович";
            this.Rank = rnd.Next(1, 10);
            this.TableNumber = i;
            Wages.Add(new Wage(this.Rank));

        }

        public Worker(bool p)
        {
            i += 1;
            Wages = new List<Wage>();
            this.surname = "Иванов";
            this.name = "Иван";
            this.lastname = "Иванович";
            this.Rank = rnd.Next(1, 10);
            this.TableNumber = i;

        }

        public Worker(string surname, string name, string lastname, int rank, int tableNumber)
        {
            Wages = new List<Wage>();
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.Rank = rank;
            TableNumber = tableNumber;
        }
        public string Surname
        {
            set
            {
                bool point = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.IsDigit(value[i])) point = false;
                }
                if (point) this.name = value;
                else Console.WriteLine("Wrong data format!");
            }
            get { return this.surname; }

        }

        public string Name
        {
            set
            {
                bool point = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.IsDigit(value[i])) point = false;
                }
                if (point) this.name = value;
                else Console.WriteLine("Wrong data format!");

            }
            get { return this.name; }

        }

        public string Lastname
        {
            set
            {
                bool point = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.IsDigit(value[i])) point = false;

                }
                if (point) this.name = value;
                else Console.WriteLine("Wrong data format!");
            }
            get { return this.lastname; }
        }
        public void AssignAWage() { Wages.Add(new Wage(this.Rank)); }
        public void AssignAWage(Wage wage) { Wages.Add(wage); }
        public void AssignAFine(double finePercent) { Wages[Wages.Count - 1].Salary = Wages[Wages.Count - 1].Salary - (Wages[Wages.Count - 1].Salary * finePercent / 100); }
        public void DeleteAWage() { Wages.RemoveAt(Wages.Count - 1); }
    }
}
