using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgammon
{
    //private static Player player1;
    //private static Player player2;
    //private static Board board;
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            // pro začátek bude začínat hráč 1 pak udělám házení kostkami
            // vytvořit objekt board
            // střídání hráčů 
            // handle/while dokud hra neskončí
            // házení kostek    
            Console.ReadLine();

        }
    

    }
}
