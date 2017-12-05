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
    public partial class finalForm : Form
    {
        public finalForm()
        {
           // this.BackgroundImage = Properties.Resources._22151994;
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                                                        "Data Source= ../addressDatabase.accdb"); //the oledb connection and connection string make sure to add using System.Data.OleDB
        string streetNumber;
        string streetName;
        string streetType;
        string state;
        string zip;
        string city;
        string img;


        //logic that will load a picture.
        private void displayImage()
        {

            Bitmap image = new Bitmap(img); //img set below, img set by database
            pb_destination.Image = (Image)image;

            Controls.Add(pb_destination);
        }

        private void finalForm_Load(object sender, EventArgs e)
        {
           connection.Open(); //this will open the connection to the access database
            OleDbCommand command = new OleDbCommand(); //this will give a command to the access database
            command.Connection = connection; //now the command knows what the connection information is.
            string commandString = "SELECT * FROM Addresses WHERE [City] ='" + citiesForm.city + "' AND [streetNumber] ='" + addressNumber.number + "' AND [State ab] = '" + stateForm.selectedState +"'";
            command.CommandText = commandString; //this declares what query we want to execute;
            OleDbDataReader reader = command.ExecuteReader();


            while (reader.Read()) //reads through every entry that the database sent over. Should only be one entry in this class. 
            {
                
                streetNumber = reader.GetString(1);
                streetName = reader.GetString(2);
                streetType = reader.GetString(3);
                city = reader.GetString(4);
                state = reader.GetString(5);
                zip = reader.GetString(6);
                img = reader.GetString(7);

            }
            //adds the elements to the form
            tb_streetAddress.Text = streetNumber + " " + streetName; 
            tb_cityStateZip.Text = city + " " + state + " " + zip;
            displayImage();
                 

        }
        //this is the logic to start over with a new address
        private void btn_newDest_Click(object sender, EventArgs e)
        {
            stateForm newDest = new stateForm();
            newDest.Show();
            this.Close(); //close this form so that its fresh when we come back to it.


        }
    }
}
