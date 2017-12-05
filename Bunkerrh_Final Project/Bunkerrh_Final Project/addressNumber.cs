/************************************
 * Ryan Bunker
 * Final Project
 * IT 3045
 * Due December 4 2017
 * Prof: Bill Nicholson
 * Create the GUI for GPS software
 * This is the code to add the address number
 * *********************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunkerrh_Final_Project
{
    public partial class addressNumber : Form
    {
        public addressNumber()
        {
            InitializeComponent();
        }

       //get set method for the number method
        public static string number { get; set; }

        //the submit button that sends us to the next page. 
        private void btn_addressNumberSubmit_Click(object sender, EventArgs e)
        {
            {
                this.Visible = false;
                citiesForm cities = new citiesForm();
                cities.Show();
                number = tb_addressNumber.Text.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            stateForm stateform = new stateForm();
            stateform.Show();
            this.Close();
        }
    }
}
