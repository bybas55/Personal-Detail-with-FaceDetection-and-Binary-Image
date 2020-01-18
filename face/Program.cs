using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace face
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginn());
            //Application.Run(new facedetection());
            //Application.Run(new personeladd());
            //Application.Run(new admin());
            //Application.Run(new personellist());

        }
    }
}
