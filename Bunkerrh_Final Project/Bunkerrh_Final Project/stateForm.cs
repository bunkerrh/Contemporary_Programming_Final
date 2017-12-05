/************************************
 * Ryan Bunker
 * Final Project
 * IT 3045
 * Due December 4 2017
 * Prof: Bill Nicholson
 * Create the GUI for GPS software
 * The form where we will choose what state we are in
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
using System.Data.OleDb;

namespace Bunkerrh_Final_Project
{
    public partial class stateForm : Form
    {

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                  "Data Source= ../addressDatabase.accdb"); //the oledb connection and connection string make sure to add using System.Data.OleDB
        
        public static string selectedState { get; set; }
    
        
        
        public stateForm()
        {
            InitializeComponent();
        }

        private void stateForm_Load(object sender, EventArgs e)
        {
         

            connection.Open(); //this will open the connection to the access database
            OleDbCommand command = new OleDbCommand(); //this will give a command to the access database
            command.Connection = connection; //now the command knows what the connection information is.
            command.CommandText = "select * from States"; //this declares what query we want to execute;
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                CB_States.Items.Add(reader.GetString(1)); //this way if the states every change all we have to do is update the database
            }


            connection.Close();

        }

        private void btn_stateSubmit_Click(object sender, EventArgs e)
        {
            selectedState = CB_States.SelectedItem.ToString();
            this.Visible = false;
            addressNumber addressNumberForm = new addressNumber();
            addressNumberForm.Show();
        }
    }
}
