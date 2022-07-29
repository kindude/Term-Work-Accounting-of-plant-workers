using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            LogIn login = new LogIn();
            login.ShowDialog();
        }
    }
}
