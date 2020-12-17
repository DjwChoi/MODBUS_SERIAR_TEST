using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODBUS_SERIAR
{
    static class Program
    {
        public static FormMain mFormMain = null;
        
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                mFormMain = new FormMain();

                Application.Run(mFormMain);
            }
            catch (Exception eMain)
            {
                MessageBox.Show(eMain.Message);
            }
        }
    }
}
