using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Add_Edit_Worker : Form
    {
        string message = "Одно из полей было введено не верно!";
        string caption = "Предупреждение";
        DialogResult result,result1;
        Add_Edit_Salary add_Edit_Salary;
        private bool edit;
        private Worker worker;
       
        public Add_Edit_Worker(bool edit)
        {
            InitializeComponent();
            if (!edit)
            {
                this.button2.Visible = false;
                this.button1.Visible = true;
            }
            else
            {
                this.button2.Visible = true;
                this.button1.Visible = false;
            }
            this.edit = edit;
        }
        public Add_Edit_Worker(bool edit,Worker worker)
        {
            InitializeComponent();
            if (!edit)
            {
                this.button2.Visible = false;
                this.button1.Visible = true;
            }
            else
            {
                this.button2.Visible = true;
                this.button1.Visible = false;
            }
            this.edit = edit;
            this.worker = worker;
        }

        private void trackBar1_Scroll(object sender, EventArgs e) { this.label6.Text = (this.trackBar1.Value).ToString(); }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.trackBar1.Value = 1;
            this.label6.Text = (this.trackBar1.Value).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool ex = true;
            if (!int.TryParse(this.textBox4.Text, out int num) && this.textBox4.Text != "")
                {
                result = MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ex = false;
                if (result == DialogResult.Yes) this.Close();
            }
            if (isAnyDigit(this.textBox1.Text) || isAnyDigit(this.textBox2.Text) || isAnyDigit(this.textBox3.Text))
            {
                result = MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ex = false;
                if (result == DialogResult.Yes) this.Close();
            }
            if (ex)
            {
                worker = new Worker(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.trackBar1.Value, Int32.Parse(this.textBox4.Text));
                result1 = MessageBox.Show(this, "Хотите добавить параметры заработной платы?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result1 == DialogResult.Yes)
                {
                    add_Edit_Salary = new Add_Edit_Salary(false, worker);
                    add_Edit_Salary.ShowDialog();
                    worker.Wages.Add(add_Edit_Salary.ReturnWage());
                    this.Close();
                }
                else this.Close();
            }
        }

        public bool isAnyDigit(string str)
        {
            foreach(char c in str)
            {
                if ( c >= '0' && c <= '9') return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ex = true;
            if (!int.TryParse(this.textBox4.Text, out int num) && this.textBox4.Text != "")
            {
                result = MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ex = false;
            }
            if (isAnyDigit(this.textBox1.Text) || isAnyDigit(this.textBox2.Text) || isAnyDigit(this.textBox3.Text))
            {
                result = MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ex = false;
            }
            if (ex)
            {
                worker = new Worker(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.trackBar1.Value, Int32.Parse(this.textBox4.Text));
                this.Close();
            }
        }

        private void Add_Edit_Worker_Load(object sender, EventArgs e)
        {
            this.button1.UseVisualStyleBackColor = true;
            this.button1.FlatAppearance.BorderSize = 0;
            this.trackBar1.BackColor = System.Drawing.Color.DimGray;
            if(edit)
            {
                this.textBox1.Text = worker.Surname;
                this.textBox2.Text = worker.Name;
                this.textBox3.Text = worker.Lastname;
                this.trackBar1.Value = worker.Rank;
                this.textBox4.Text = worker.TableNumber.ToString();
                this.label6.Text = this.trackBar1.Value.ToString();
            }
        }
        public Worker ReturnWorker() { return worker; }
    }
}
