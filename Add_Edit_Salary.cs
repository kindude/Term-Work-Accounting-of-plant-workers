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
    public partial class Add_Edit_Salary : Form
    {
        string message = "Одно из полей было введено не верно!";
        string caption = "Предупреждение";
        DialogResult result;
        private Wage wage;
        private Worker worker;
        private bool edit;
        public Add_Edit_Salary(bool edit,Worker worker)
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
            this.worker = worker;
            this.edit = edit;
        }

        public Add_Edit_Salary(bool edit, Worker worker, Wage wage)
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
            this.wage = wage;
            this.edit = edit;
            this.worker = worker;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool ex = true;
            try { 
                if(isAnyChar(this.textBox1.Text) || isAnyChar(this.textBox2.Text) || isAnyChar(this.textBox3.Text))
                {
                    result = MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ex = false;
                    if (result == DialogResult.Yes) this.Close();
                }
                if (Int32.Parse(this.maskedTextBox1.Text) >= 13 || Int32.Parse(this.maskedTextBox1.Text) <= 0)
                {
                    result = MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ex = false;
                    if (result == DialogResult.Yes) { this.Close(); }
                }
            }
            catch(System.FormatException)
            {
                result = MessageBox.Show(this, "Значения обязательные для зполнения!", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.Yes) this.Close();
            }
            if(ex)
            {
                bool premium = false;
                if (this.radioButton1.Checked) { premium = true; }
                wage = new Wage(Double.Parse(this.textBox1.Text), Convert.ToDouble(this.textBox2.Text),premium, Double.Parse(this.textBox3.Text),Convert.ToInt32(this.maskedTextBox1.Text), Convert.ToInt32(this.maskedTextBox2.Text), worker.Rank);
                this.Close();
            }
            
        }
        public bool isAnyChar(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9') { return true;}
            }
            return false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) { this.textBox3.Enabled = true; }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) { this.textBox3.Enabled = false; }

        private void Add_Edit_Salary_Load(object sender, EventArgs e)
        {
            this.button1.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.BorderSize = 0;
            if(edit)
            {
                this.textBox1.Text = wage.Hours.ToString();
                this.textBox2.Text = wage.PricePerHour.ToString();
                if (wage.Premium) this.radioButton1.Checked = true;
                else this.radioButton2.Checked = true;
                this.textBox3.Text = wage.PremiumPercent.ToString();
                this.maskedTextBox1.Text = wage.Month.ToString();
                this.maskedTextBox2.Text = wage.Year.ToString();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox) ((TextBox)c).Text = null;
            this.maskedTextBox1.Text = null;
            this.maskedTextBox2.Text = null;
        }

        public Wage ReturnWage() { return wage; }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ex = true;
            try
            {
                if (isAnyChar(this.textBox1.Text) || isAnyChar(this.textBox2.Text) || isAnyChar(this.textBox3.Text))
                {
                    result = MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ex = false;
                    if (result == DialogResult.Yes) { this.Close(); }
                }

                if (Int32.Parse(this.maskedTextBox1.Text) >= 13 || Int32.Parse(this.maskedTextBox1.Text) <= 0)
                {
                    result = MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ex = false;
                    if (result == DialogResult.Yes) { this.Close(); }
                }
            }
            catch (System.FormatException)
            {
                string message1;
                message1 = "Значения обязательные для зполнения!";
                result = MessageBox.Show(this, message1, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.Yes) { this.Close(); }
            }
            if (ex)
            {
                wage.Hours = Convert.ToDouble(this.textBox1.Text);
                wage.PricePerHour = Convert.ToDouble(this.textBox2.Text);
                wage.Premium = radioButton1.Checked;
                wage.PremiumPercent = Convert.ToDouble(this.textBox3.Text);
                wage.Month = Convert.ToInt32(this.maskedTextBox1.Text);
                wage.Year = Convert.ToInt32(this.maskedTextBox2.Text);
                wage.Salary = wage.SalaryAfterTaxes();
                this.Close();
            }
        }
    }
}
