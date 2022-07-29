using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace Kursach
{
    public partial class MainForm : Form
    {
        public Factory factory;
        public Add_Edit_Worker add_Edit_Worker;
        Add_Edit_Salary add_Edit_Salary;
        Add_Edit_Worksop add_Edit_Worksop;
        List<String> files;
        BindingSource SalariesSource, WorkersSource;
        int TempWorkshopIndex, TempWorkerIndex, TempSalaryIndex;
        WorkWithFile wwf;
        Diagram diagram;
        public MainForm()
        {
            InitializeComponent();
            factory = new Factory();
            SalariesSource = new BindingSource();
            WorkersSource = new BindingSource();
            wwf = new WorkWithFile(files);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.label1.BackColor = System.Drawing.Color.Transparent;
            dataGridView1.AutoResizeRows();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            this.Location = new Point(resolution.Width / 2 - this.Width / 2, resolution.Height / 2 - this.Height / 2);
            this.WorkerAddToolStripMenuItem.Click += button2_Click; //Добавить работника
            this.SalaryAddToolStripMenuItem.Click += button5_Click; //Добавить зарплату
            this.работникToolStripMenuItem1.Click += button4_Click; //Удалить работника
            this.зарплатаToolStripMenuItem1.Click += button7_Click; //Удалить зарплату
            this.цехToolStripMenuItem1.Click += button1_Click; //Удалить цех
            this.работникToolStripMenuItem2.Click += button3_Click;
            this.зарплатаToolStripMenuItem2.Click += button6_Click;
        }
        private void button2_Click(object sender, EventArgs e) // Добавить работника через кнопку
        {
            add_Edit_Worker = new Add_Edit_Worker(false);
            add_Edit_Worker.ShowDialog();
            if (add_Edit_Worker.ReturnWorker() != null)
            {
                Worker worker = add_Edit_Worker.ReturnWorker();
                factory.WorkShops[TempWorkshopIndex].ToHireAWorker(factory.UniqueTableNumber(worker));
                WorkersSource.ResetBindings(false);
            }
        }
        private void button3_Click(object sender, EventArgs e) // Редактировать работнк кнопка
        {
            add_Edit_Worker = new Add_Edit_Worker(true, factory.WorkShops[TempWorkshopIndex].Workers[TempWorkerIndex]);
            add_Edit_Worker.ShowDialog();
            factory.WorkShops[TempWorkshopIndex].Workers.RemoveAt(TempWorkerIndex);
            factory.WorkShops[TempWorkshopIndex].Workers.Insert(TempWorkerIndex, factory.UniqueTableNumber(add_Edit_Worker.ReturnWorker()));
            WorkersSource.ResetBindings(false);

        }
        private void button5_Click(object sender, EventArgs e) //Назначить зарплату кнопка
        {
            add_Edit_Salary = new Add_Edit_Salary(false, factory.WorkShops[TempWorkshopIndex].Workers[TempWorkerIndex]);
            add_Edit_Salary.ShowDialog();
            factory.WorkShops[TempWorkshopIndex].Workers[TempWorkerIndex].AssignAWage(add_Edit_Salary.ReturnWage());
            SalariesSource.ResetBindings(false);

        }
        private void button6_Click(object sender, EventArgs e) //Редактировать зарплату через кнопку
        {
            add_Edit_Salary = new Add_Edit_Salary(true, factory.WorkShops[TempWorkshopIndex].Workers[TempWorkerIndex], factory.WorkShops[TempWorkshopIndex].Workers[TempWorkerIndex].Wages[TempSalaryIndex]);
            add_Edit_Salary.ShowDialog();
            factory.WorkShops[TempWorkshopIndex].Workers[TempWorkerIndex].Wages.RemoveAt(TempSalaryIndex);
            factory.WorkShops[TempWorkshopIndex].Workers[TempWorkerIndex].Wages.Insert(TempSalaryIndex, add_Edit_Salary.ReturnWage());
            SalariesSource.ResetBindings(false);
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Добавить цех")
            {
                try
                {
                    add_Edit_Worksop = new Add_Edit_Worksop(false);
                    add_Edit_Worksop.ShowDialog();
                    factory.WorkShops.Add(add_Edit_Worksop.ReturnWorkShop());
                    comboBox1.Items.Add(factory.WorkShops[factory.WorkShops.Count - 1].Number);
                    DataGridView1Settings();
                }
                catch (System.NullReferenceException) { };
            }
            else
            {
                WorkersSource.DataSource = factory.WorkShops[comboBox1.SelectedIndex - 1].Workers;
                WorkersSource.ResetBindings(false);
                TempWorkshopIndex = comboBox1.SelectedIndex - 1;
                if (dataGridView1.CurrentCell != null)
                {
                    TempWorkerIndex = dataGridView1.CurrentCell.RowIndex;
                    SalariesSource.DataSource = factory.WorkShops[TempWorkshopIndex].Workers[TempWorkerIndex].Wages;
                    SalariesSource.ResetBindings(false);
                    TempSalaryIndex = dataGridView2.CurrentCell.RowIndex;
                    DataGridView2Settings();
                }
                else
                {
                    MessageBox.Show(this, "В данном заводе нет работников", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SalariesSource.DataSource = null;
                    WorkersSource.DataSource = null;
                }
            }
        }
       private void цехToolStripMenuItem_Click(object sender, EventArgs e) //Добавить цех через меню
        {
            try
            {
                add_Edit_Worksop = new Add_Edit_Worksop(false);
                add_Edit_Worksop.ShowDialog();
                factory.WorkShops.Add(add_Edit_Worksop.ReturnWorkShop());
                comboBox1.Items.Add(factory.WorkShops[factory.WorkShops.Count - 1].Number);
            }
            catch (System.NullReferenceException) { };
        }
      
        private void цехToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            add_Edit_Worksop = new Add_Edit_Worksop(true, factory.WorkShops[TempWorkshopIndex]);
            add_Edit_Worksop.ShowDialog();
            factory.DeleteWorkshop(TempWorkshopIndex);
            factory.WorkShops.Insert(TempWorkshopIndex, add_Edit_Worksop.ReturnWorkShop());
            comboBox1.Items.RemoveAt(TempWorkshopIndex + 1);
            comboBox1.Items.Insert(TempWorkshopIndex + 1, add_Edit_Worksop.ReturnWorkShop().Number);
            comboBox1.SelectedIndex = TempWorkshopIndex + 1;
            WorkersSource.ResetBindings(false);
        }
      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.CurrentCell == dataGridView1[1, i])
                {
                    SalariesSource.DataSource = factory.WorkShops[TempWorkshopIndex].Workers[i].Wages;
                    SalariesSource.ResetBindings(false);
                    DataGridView2Settings();
                }
            }
            TempWorkerIndex = dataGridView1.CurrentCell.RowIndex;
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TempSalaryIndex = dataGridView2.CurrentCell.RowIndex;
        }
     
        private void button4_Click(object sender, EventArgs e)  // Удалить работника через кнопку
        {
            try
            {
                factory.WorkShops[TempWorkshopIndex].ToFireaWorker(TempWorkerIndex);
                WorkersSource.ResetBindings(false);
            }
            catch (System.ArgumentOutOfRangeException) { };
        }
        private void button7_Click(object sender, EventArgs e) //Удалить зп через кнопку
        {
            try
            {
                factory.WorkShops[TempWorkshopIndex].Workers[TempWorkerIndex].Wages.RemoveAt(TempSalaryIndex);
                SalariesSource.ResetBindings(false);
            }
            catch (System.ArgumentOutOfRangeException) { };
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                factory.WorkShops.RemoveAt(TempWorkshopIndex);
                comboBox1.Items.RemoveAt(TempWorkshopIndex + 1);
                if (comboBox1.Items.Count == 1)
                {
                    WorkersSource.DataSource = null;
                    SalariesSource.DataSource = null;
                }
            }
            catch (System.ArgumentOutOfRangeException) { };
        }
       
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
                TempWorkerIndex = 0;
                SalariesSource.DataSource = factory.WorkShops[TempWorkshopIndex].Workers[TempWorkerIndex].Wages;
                dataGridView2.DataSource = SalariesSource;
            }
            catch (System.ArgumentOutOfRangeException) { };
        }
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1];
                TempWorkerIndex = factory.WorkShops[TempWorkshopIndex].Workers.Count - 1;
                SalariesSource.DataSource = factory.WorkShops[TempWorkshopIndex].Workers[TempWorkerIndex].Wages;
                dataGridView2.DataSource = SalariesSource;
                DataGridView2Settings();
            }
            catch (System.ArgumentOutOfRangeException) { };
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.CurrentCell = dataGridView2.Rows[0].Cells[9];
                TempSalaryIndex = 0;
            }
            catch (System.ArgumentOutOfRangeException) { };
        }
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[9];
                TempSalaryIndex = factory.WorkShops[TempWorkshopIndex].Workers[TempWorkerIndex].Wages.Count - 1;
            }
            catch (System.ArgumentOutOfRangeException) { };
        }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            this.files = wwf.FileSettings();
           
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.label1.Text = factory.FactoryName;
            DataClick();
            this.DiagramToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveAsToolStripMenuItem.Enabled = false;
            this.DiagramToolStripMenuItem.Enabled = true;
            this.SaveToolStripMenuItem.Enabled = true;
            this.SaveAsToolStripMenuItem.Enabled = true;
        }
        private void DataClick()
        {
            WorkersSource.DataSource = factory.WorkShops[TempWorkshopIndex].Workers;
            SalariesSource.DataSource = factory.WorkShops[TempWorkshopIndex].Workers[TempWorkerIndex].Wages;
            dataGridView1.DataSource = WorkersSource;
            DataGridView1Settings();
            dataGridView2.DataSource = SalariesSource;
            DataGridView2Settings();
            string item = "Добавить цех";
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add(item);
            this.label1.Text = factory.FactoryName;
            for (int i = 0; i < factory.WorkShops.Count; i++)
            {
                item = factory.WorkShops[i].Number;
                this.comboBox1.Items.Add(item);
            }
            this.comboBox1.SelectedIndex = 1;
            this.button1.Enabled = true;
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;
            this.button10.Enabled = true;
            this.button11.Enabled = true;
            this.EditToolStripMenuItem.Enabled = true;
            this.AddToolStripMenuItem1.Enabled = true;
            this.DeleteToolStripMenuItem.Enabled = true;
            this.ViewToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Enabled = true;
            this.SaveAsToolStripMenuItem.Enabled = true;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null) TempWorkerIndex = dataGridView1.CurrentRow.Index;
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null) TempSalaryIndex = dataGridView2.CurrentRow.Index;
        }
        private void DataGridView1Settings()
        {
           dataGridView1.AutoResizeRows();
            dataGridView1.Columns[0].HeaderText = "Разряд";
            dataGridView1.Columns[1].HeaderText = "Табельный номер";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Имя";
            dataGridView1.Columns[4].HeaderText = "Отчество";
            dataGridView1.Columns[0].DisplayIndex = 4;
        }
        private void DataGridView2Settings()
        {
            dataGridView2.AutoResizeRows();
            dataGridView2.Columns[0].HeaderText = "Часы";
            dataGridView2.Columns[1].HeaderText = "З/П за час";
            dataGridView2.Columns[2].HeaderText = "Месяц";
            dataGridView2.Columns[3].HeaderText = "Год";
            dataGridView2.Columns[4].HeaderText = "Процент премии";
            dataGridView2.Columns[5].HeaderText = "Наличие премии";
            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[7].Visible = false;
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[9].HeaderText = "Зарплата";
            dataGridView2.Columns[9].DisplayIndex = 0;
            dataGridView2.Columns[5].DisplayIndex = 3;
            dataGridView2.Columns[4].DisplayIndex = 4;
            foreach (DataGridViewColumn col in dataGridView2.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files == null)
            {
                files = wwf.FileSettings();
                wwf.Save(factory);
            }
          
            if((files[0].Split('.'))[1]=="dat")
            {
                wwf.Files = files;
                wwf.SaveSerialize(factory);
            }
            else wwf.Save(factory);
        }
        private void цехToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                add_Edit_Worksop = new Add_Edit_Worksop(false);
                add_Edit_Worksop.ShowDialog();
                factory.WorkShops.Add(add_Edit_Worksop.ReturnWorkShop());
                comboBox1.Items.Add(factory.WorkShops[factory.WorkShops.Count - 1].Number);
            }
            catch (System.NullReferenceException) { };
        }
        private void диаграммаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            diagram = new Diagram(this, factory.MaxRank());
            diagram.ShowDialog();
        }

        private void цехToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            this.button3.Enabled = false;
            this.button4.Enabled = true;
            add_Edit_Worksop = new Add_Edit_Worksop(true,factory.WorkShops[TempWorkshopIndex]);
            add_Edit_Worksop.ShowDialog();
            WorkShop workshop = add_Edit_Worksop.ReturnWorkShop();
            factory.DeleteWorkshop(TempWorkshopIndex);
            factory.WorkShops.Insert(TempWorkshopIndex, workshop);
            comboBox1.Items.RemoveAt(TempWorkshopIndex + 1);
            comboBox1.Items.Insert(TempWorkshopIndex + 1, workshop.Number);
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {

            files = wwf.FileSettings();
            string[] arr = files[0].Split('.');
            if (arr[1] == "dat") wwf.SaveSerialize(factory);
            else wwf.Save(factory);
 
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream[] openFiles;
            StreamReader[] ReadFiles;
            openFiles = new FileStream[4];
            ReadFiles = new StreamReader[4];
            files = new List<string>();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "D:\\АСУ-19\\OOP\\Kursach\\bin\\Debug";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                files.Add(openFileDialog1.FileName);
                string[] arr = files[0].Split('.');
                
                if (arr[1] == "dat")
                {
                    this.factory = Serialize.DeserializeObject(files[0]);
                    DataClick();
                }
                else
                {
                    try
                    {
                        openFiles[0] = openFileDialog1.OpenFile();
                        ReadFiles[0] = new StreamReader(openFiles[0]);
                        files.Add(ReadFiles[0].ReadLine());
                        openFiles[1] = (Stream)new FileStream(files[1], FileMode.Open, FileAccess.Read);
                        ReadFiles[1] = new StreamReader(openFiles[1]);
                        files.Add(ReadFiles[1].ReadLine());
                        openFiles[2] = (Stream)new FileStream(files[2], FileMode.Open, FileAccess.Read);
                        ReadFiles[2] = new StreamReader(openFiles[2]);
                        files.Add(ReadFiles[2].ReadLine());
                        openFiles[3] = (Stream)new FileStream(files[3], FileMode.Open, FileAccess.Read);
                        ReadFiles[3] = new StreamReader(openFiles[3]);
                    }
                    catch(System.ArgumentNullException){ };
                        
                }
            }
            if (ReadFiles[0] != null && ReadFiles[1] != null && ReadFiles[2] != null && ReadFiles[3] != null)
            {
                this.factory = wwf.Open(ReadFiles, files);
                for (int i = 0; i < 4; i++)
                {
                    ReadFiles[i].Close();
                    openFiles[i].Close();
                }
                DataClick();
            }
            this.DiagramToolStripMenuItem.Enabled = true;
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы действительно хотите выйти?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes) this.Close();
        }
    }
}
