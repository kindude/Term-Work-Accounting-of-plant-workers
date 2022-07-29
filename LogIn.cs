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

namespace Kursach
{
    public partial class LogIn : Form
    {
        private List<string> login, password;
        MainForm mf;
        public LogIn()
        {
            InitializeComponent();
            login = new List<string>();
            password = new List<string>();
            ReadLogIN();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            this.Location = new Point(resolution.Width / 2 - this.Width / 2, resolution.Height / 2 - this.Height / 2);
        }

        private void ReadLogIN()
        {
            Stream openFiles;
            openFiles = (Stream)new FileStream("LogIN.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(openFiles);

            while(!sr.EndOfStream)
            {
                string[] tmp;
                tmp = sr.ReadLine().Split('\t');
                login.Add(tmp[0]);
                password.Add(tmp[1]);
            }
            sr.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool pointer = true;
            for (int i = 0; i < login.Count; i++)
            {
                string loginGet = this.textBox1.Text;
                string passwordGet = this.textBox2.Text;
                if (loginGet == login[i] && passwordGet == password[i])
                {
                    mf = new MainForm();
                    Console.WriteLine("Pass");
                    pointer = true;
                    this.Hide();
                    mf.ShowDialog();
                   
                    break;
                }
                else pointer = false;
             }
            if(!pointer) MessageBox.Show("Пароль или Логин введены неправильно", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else this.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}