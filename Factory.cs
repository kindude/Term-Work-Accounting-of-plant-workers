using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    [Serializable]
    public class Factory
    {
        public List<WorkShop> WorkShops { get; set; }
        public string FactoryName { get; set; }
        public Factory()
        {
            FactoryName = "Небольшой завод";
            WorkShops = new List<WorkShop>();
            for(int i = 0; i < 3; i++)
            {
                WorkShops.Add(new WorkShop());
            }
        }
        public Factory(bool isEmpty)
        {
            this.FactoryName = FactoryName;
            WorkShops = new List<WorkShop>();
        }
        
        public void  AddWorkshop(WorkShop workShop)
        {
            this.WorkShops.Add(workShop);
        }
        public void DeleteWorkshop(int index)
        {
            this.WorkShops.RemoveAt(index);
        }
        public Worker UniqueTableNumber(Worker worker)
        {
            Worker worker1 = worker;
            bool point = true;
            int max = -1000;
            for (int i = 0; i < this.WorkShops.Count; i++)
            {
                for (int j = 0; j < this.WorkShops[i].Workers.Count; j++)
                {
                    if (worker1.TableNumber == this.WorkShops[i].Workers[j].TableNumber)
                    {
                        point = false;
                    }

                    if (this.WorkShops[i].Workers[j].TableNumber > max)
                    {
                        max = this.WorkShops[i].Workers[j].TableNumber;
                    }
                }
            }
            if (!point) worker1.TableNumber = max + 1;
            return worker1;
        }
        public int MaxRank()
        {
            int max = -1;
            for (int i = 0; i < this.WorkShops.Count; i++)
            {
                for(int j=0;j<this.WorkShops[i].Workers.Count;j++)
                {
                    if (this.WorkShops[i].Workers[j].Rank > max) max = this.WorkShops[i].Workers[j].Rank;
                }
            }
            return max;
        }
    }
}
