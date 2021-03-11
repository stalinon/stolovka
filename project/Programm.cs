using System;
using System.Windows.Forms;

namespace cafe
{
    class Programm
    {
        [STAThread]
        static void Main()
        {
            MainForm form = new MainForm("Окно", 720, 500);
            Application.Run(form);

        }
    }
}
