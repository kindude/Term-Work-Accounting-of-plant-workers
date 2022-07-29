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
    public partial class Add_Edit_Worksop : Form
    {
        string message = "Заполните название цеха!";
        string caption = "Предупреждение";
        DialogResult result;
        private WorkShop workShop;
        public Add_Edit_Worksop(bool edit,WorkShop workShop)
        {
            InitializeComponent();
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button4.Visible = true;
            this.button3.Visible = false;
            this.workShop = workShop;
            this.textBox1.Text = this.workShop.Number;
        }

        public Add_Edit_Worksop(bool edit)
        {
            InitializeComponent();
            this.button4.Visible = false;
            this.button3.Visible = false;
        }
        private void Add_Edit_Worksop_Load(object sender, EventArgs e)
        {
            this.button3.FlatAppearance.BorderSize = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button3.Visible = true;
            this.numericUpDown1.Visible = true;
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "") { MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                workShop = new WorkShop(this.textBox1.Text, Convert.ToInt32(this.numericUpDown1.Value));
                for (int i = 0; i < Convert.ToInt32(this.numericUpDown1.Value); i++)
                {
                    Add_Edit_Worker add_Edit_Worker = new Add_Edit_Worker(false);
                    add_Edit_Worker.ShowDialog();
                    workShop.Workers.Add(add_Edit_Worker.ReturnWorker());
                    this.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "") result = MessageBox.Show(this, message, caption,  MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                workShop.Number = this.textBox1.Text;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "") { MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                workShop = new WorkShop(this.textBox1.Text);
                this.Close();
            }
            
        }
        public WorkShop ReturnWorkShop() { return this.workShop; }
    }
}
