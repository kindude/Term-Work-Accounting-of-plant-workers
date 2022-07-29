using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    [Serializable]
    public class WorkShop
    {
        public string Number { get; set; }
        public List<Worker> Workers { get; set; }
        static int i = 1;
      
        public WorkShop()
        {
            this.Number = "Цех № " + i.ToString();
            Workers = new List<Worker>();
            for (int i = 0; i < 5; i++)
            {
                Workers.Add(new Worker());
            }
            i++;
        }
      
        public WorkShop(string Number)
        {
            this.Number = Number;
            Workers = new List<Worker>();
            for (int i = 0; i < 5; i++)
            {
                Workers.Add(new Worker());
            }
            i++;
        }

        public WorkShop(string Number, bool isEmpty)
        {
            this.Number = Number;
            Workers = new List<Worker>();
        }
        public WorkShop(string number, int q)
        {
            this.Number = number;
            Workers = new List<Worker>();
        }

        public void ToHireAWorker(Worker worker){ this.Workers.Add(worker); }
        public void ToFireaWorker(int i) { this.Workers.RemoveAt(i); }
        public double[] AverageSalaryForRank()
        {
            int c;
            double[] averageSalaries = new double[10];
            int[] RankMas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i=0;i<10;i++)
            {
                averageSalaries[i] = 0;
            }
            for (int i = 0; i < RankMas.Length; i++) 
            {
                c = 0;
                for (int j =0;j<this.Workers.Count;j++)
                {
                    
                    if (RankMas[i] == this.Workers[j].Rank)
                    {
                        averageSalaries[i] += Average(j);
                        c++;
                    }
                }
                if(c!=0) averageSalaries[i] = averageSalaries[i] / c;
            }
            return averageSalaries;
        }
         public double Average(int k )
         {
            double sum = 0;
            for(int i=0;i<Workers[k].Wages.Count;i++)
            {
                sum += Workers[k].Wages[i].Salary;
            }
            return sum / Workers[k].Wages.Count;
         }

    }
}
