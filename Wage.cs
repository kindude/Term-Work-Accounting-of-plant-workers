using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    [Serializable]
    public class Wage
    {
        public double Hours { get; set; }
        public double PricePerHour { get; set; }
        public int Month { get; set; }
        public  int Year { get; set; }
        public double PremiumPercent { get; set; }
        public bool Premium { get; set; }
        public float IncomeTax { get; }
        public float UnionFee { get; }
        public float PensionContributions { get; }
        private int WorkerRank;
        private double BaseWage;
        public double Salary { get; set; }
        static Random rndm = new Random();
        static Random rndy = new Random();

        public Wage()
        {

        }
        public Wage(int WorkerRank)
        {
            this.IncomeTax = 13;
            this.UnionFee = 1;
            this.PensionContributions = 1;
            this.PricePerHour = 200;
            this.Hours = 160;
            this.Year = rndy.Next(1999,2021);
            this.Month = rndm.Next(1,12);
           
            this.WorkerRank = WorkerRank;
            SalaryAfterTaxes();
            if (Premium) AssignAPremium();
        }

        public Wage( double hours, double pricePerHour, bool premium, double percent, int month, int year,int WorkerRank)
        {
            this.IncomeTax = 13;
            this.UnionFee = 1;
            this.PensionContributions = 1;
            this.PricePerHour = pricePerHour;
            this.Hours = hours;
            this.Month = month;
            this.Year = year;
            this.WorkerRank = WorkerRank;
            this.Premium = premium;
            this.PremiumPercent = percent;
            SalaryAfterTaxes();
            if (Premium) AssignAPremium();
        }

        public double SalaryAfterTaxes()
        {
            this.BaseWage = PricePerHour * Hours;
            this.Salary = this.BaseWage - ((this.BaseWage * this.IncomeTax / 100) + (this.BaseWage * this.UnionFee / 100) + (this.BaseWage * this.PensionContributions / 100)) + AssignAPremium();
            if(this.WorkerRank > 1)
            {
                this.Salary = this.Salary + (this.Salary * this.WorkerRank / 10);
            }

            return this.Salary;
        }
        private double AssignAPremium()
        {
            if (this.Premium) return this.BaseWage * this.PremiumPercent / 100;
            else return 0;
        }
    }
}
