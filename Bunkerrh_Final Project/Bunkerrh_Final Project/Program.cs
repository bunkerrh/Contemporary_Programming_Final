/************************************
 * Ryan Bunker
 * Final Project
 * IT 3045
 * Due December 4 2017
 * Prof: Bill Nicholson
 * Create the GUI for GPS software
 * The main class
 * *********************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunkerrh_Final_Project
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
            Application.Run(new stateForm()); //this is the form that we will start in
        }
    }
}
