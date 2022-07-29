using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Kursach
{
    
   public class WorkWithFile :Form
    {
        public List<String> Files { get; set; }
        FileStream[] fileStreams;
        public WorkWithFile(List<String> files)
        {
            this.Files = files;
        }

        public  List<String> FileSettings()
        {
            String[] labels = { "Завод", "Цеха", "Рабочие", "Зарплаты" };
            Files = new List<string>();
            fileStreams = new FileStream[labels.Length];
            CreateFile cf = new CreateFile();
            for (int i = 0; i < labels.Length; i++)
            {
                cf.changeLabelText(labels[i]);
                cf.ShowDialog();
                if (cf.ReturnPath() != null)
                {
                    string[] arr = cf.ReturnPath().Split('.');
                    Files.Add(arr[0] + "." + arr[1]);
                        
                    CreatingFiles(i);
                    if(arr[1] == "dat") break;
                }
                else
                {
                    MessageBox.Show(this, "Не удалось создать файлы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            return Files;
        }

        public void CreatingFiles(int i)
        {
            try
            {
                fileStreams[i] = new FileStream(Files[i], FileMode.CreateNew, FileAccess.ReadWrite);
                MessageBox.Show("Файл создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.IO.IOException)
            {
                DialogResult result = MessageBox.Show("Файл с таким название уже существует\nПерезаписать файл?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    fileStreams[i] = new FileStream(Files[i], FileMode.Create, FileAccess.ReadWrite);
                    MessageBox.Show( "Файл создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            fileStreams[i].Close();
        }

        public void SaveSerialize(Factory factory)
        {
            try
            {
                Serialize.SerializeObject(factory, Files[0]);
            }
            catch (System.ArgumentOutOfRangeException) {  };
        }
        public  void Save(Factory factory)
        {
            FileStream[] savingFiles;
            StreamWriter[] WriteFiles;
            savingFiles = new FileStream[Files.Count];
            WriteFiles = new StreamWriter[Files.Count];

            for (int i = 0; i < Files.Count; i++)
            {
                File.WriteAllText(Files[i], String.Empty);
                savingFiles[i] = new FileStream(Files[i], FileMode.Open, FileAccess.ReadWrite);
                WriteFiles[i] = new StreamWriter(savingFiles[i], Encoding.UTF8);
            }
            WriteFiles[0].WriteLine(Files[1]);
            WriteFiles[1].WriteLine(Files[2]);
            WriteFiles[2].WriteLine(Files[3]);
            WriteFiles[0].WriteLine(factory.FactoryName + "\t" + factory.WorkShops.Count.ToString());

            for (int i = 0; i < factory.WorkShops.Count; i++)
            {
                WriteFiles[1].WriteLine(factory.WorkShops[i].Number + "\t");
                for (int j = 0; j < factory.WorkShops[i].Workers.Count; j++)
                {
                    WriteFiles[2].WriteLine(factory.WorkShops[i].Number + "\t" + factory.WorkShops[i].Workers[j].TableNumber + "\t" + factory.WorkShops[i].Workers[j].Surname +  "\t" + factory.WorkShops[i].Workers[j].Name + "\t" + factory.WorkShops[i].Workers[j].Lastname + "\t" + factory.WorkShops[i].Workers[j].Rank );
                    for (int k = 0; k < factory.WorkShops[i].Workers[j].Wages.Count; k++)
                    {
                        WriteFiles[3].WriteLine(factory.WorkShops[i].Workers[j].TableNumber + "\t"+ factory.WorkShops[i].Workers[j].Wages[k].Salary +"\t" + factory.WorkShops[i].Workers[j].Wages[k].Hours + "\t" + factory.WorkShops[i].Workers[j].Wages[k].PricePerHour + "\t" + factory.WorkShops[i].Workers[j].Wages[k].Premium + "\t" + factory.WorkShops[i].Workers[j].Wages[k].PremiumPercent + "\t" + factory.WorkShops[i].Workers[j].Wages[k].Month + "\t" + factory.WorkShops[i].Workers[j].Wages[k].Year);
                    }

                }
            }
            for (int i = 0; i < Files.Count; i++)
            {
                WriteFiles[i].Close();
                savingFiles[i].Close();
            }
        }

        public Factory Open(StreamReader[] ReadFiles,List<String> files)
        {
            Factory factory = new Factory(true);
            int k, j;
            String[] DataFactory, DataWorkshop, DataWorker, DataSalary;
           
            string[] arr = files[0].Split('.');

            if (arr[1] == "dat")
            {
                this.Files[0] = files[0]; factory = Serialize.DeserializeObject(files[0]);
            }
            else
            {
                while (!ReadFiles[0].EndOfStream)
                {
                    DataFactory = ReadFiles[0].ReadLine().Split('\t');
                    factory.FactoryName = DataFactory[0];
                    if (DataFactory[0] == "")
                    {
                        break;
                    }
                }

                while (!ReadFiles[1].EndOfStream)
                {
                    DataWorkshop = ReadFiles[1].ReadLine().Split('\t');
                    WorkShop workshop = new WorkShop(DataWorkshop[0], false);
                    factory.AddWorkshop(workshop);
                }
                while (!ReadFiles[2].EndOfStream)
                {
                    DataWorker = ReadFiles[2].ReadLine().Split('\t');
                    for (j = 0; j < factory.WorkShops.Count; j++)
                    {
                        if (factory.WorkShops[j].Number == DataWorker[0])
                        {

                            factory.WorkShops[j].ToHireAWorker(new Worker(DataWorker[2], DataWorker[3], DataWorker[4], Convert.ToInt32(DataWorker[5]), Convert.ToInt32(DataWorker[1])));
                        }
                    }
                }

                while (!ReadFiles[3].EndOfStream)
                {
                    string temp = ReadFiles[3].ReadLine();
                    DataSalary = temp.Split('\t');
                    for (j = 0; j < factory.WorkShops.Count; j++)
                    {
                        for (k = 0; k < factory.WorkShops[j].Workers.Count; k++)
                        {
                            
                            if (temp != null)
                            {
                                if (DataSalary[0] != "")
                                {
                                    if (factory.WorkShops[j].Workers[k].TableNumber == Convert.ToInt32(DataSalary[0]))
                                    {
                                        Wage wage = new Wage();
                                        wage.Hours = Convert.ToDouble(DataSalary[2]);
                                        wage.PricePerHour = Convert.ToDouble(DataSalary[3]);
                                        wage.Premium = Convert.ToBoolean(DataSalary[4]);
                                        wage.PremiumPercent = Convert.ToDouble(DataSalary[5]);
                                        wage.Month = Convert.ToInt32(DataSalary[6]);
                                        wage.Year = Convert.ToInt32(DataSalary[7]);
                                        wage.Salary = Convert.ToDouble(DataSalary[1]);
                                        factory.WorkShops[j].Workers[k].AssignAWage(wage);
                                        
                                    }
                                }
                            }
                           
                        }
                    }
                }
            }
            return factory;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "WorkWithFile";
            this.Load += new System.EventHandler(this.WorkWithFile_Load);
            this.ResumeLayout(false);

        }
        private void WorkWithFile_Load(object sender, EventArgs e)
        {

        }
    }
 
}
