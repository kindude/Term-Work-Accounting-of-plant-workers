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
    public partial class CreateFile : Form
    {
        private string path;
        private string extend;
        public CreateFile()
        {
            InitializeComponent();
            this.comboBox1.Items.Add(".dat");
            this.comboBox1.Items.Add(".txt");
            this.comboBox1.Items.Add(".doc");
            this.comboBox1.Items.Add(".csv");
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        public void changeLabelText(string label)
        {
            this.label4.Text = label;
        }
        private void CreateFile_Load(object sender, EventArgs e)
        { 
            this.comboBox1.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                path = this.textBox1.Text;
                extend = this.comboBox1.SelectedItem.ToString();
                path += extend;
                this.textBox1.Text = "";
                this.Close();
            }
            else MessageBox.Show("Заполните название файла", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public String ReturnPath() { return this.path; }
    }
}
