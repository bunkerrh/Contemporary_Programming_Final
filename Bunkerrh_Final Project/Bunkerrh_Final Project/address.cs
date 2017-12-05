/************************************
 * Ryan Bunker
 * Final Project
 * IT 3045
 * Due December 4 2017
 * Prof: Bill Nicholson
 * Create the GUI for GPS software
 * The form with the logic to decide
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
    public partial class address : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                                                        "Data Source= ../addressDatabase.accdb"); //the oledb connection and connection string make sure to add using System.Data.OleDB
        public List<string> cities = new List<string>();
        int count = 1; // we use this number within the show letter method to keep track of which letter we need to check next
        int streetCount = 1; //we use this number with the check street method to keep track of which letters we need to check
      
        public static string street { get; set; }

        private void checkStreet() { //this method will check the string that has been entered so far against the street names. Removes any entries that do not match
            
            string tempLetters;
            int citiesCount = cities.Count; //since the size of cities will count as we remove stuff from the list we need a number that wont change
         
            for (int i = citiesCount -1; i >= 0 ; i--) //iterates through cities backwards to avoid any outof bound exceptions
            {
                tempLetters = cities[i].Substring(0, streetCount).ToLower();
                if (tempLetters != tb_address.Text.ToString())
                {
                    cities.RemoveAt(i);
                }
            }
            streetCount++;
        }

       private void showLetter() //the logic to decide what letter to show after clicking on the keyboard
        {
           for (int i = 0; i < cities.Count; i++)
            {
                try //this will try the below logic. If there is an outofbound exception then we remove that city from the list since it will not be needed
                {
                    
                    string temp = cities[i];
                    char letter = temp[count];
                    switch (letter)
                        {
                        case 'a':
                            btnA.Visible = true;
                            break;
                        case 'b':
                            btnB.Visible = true;
                            break;
                        case 'c':
                            btnC.Visible = true;
                            break;
                        case 'd':
                            btnD.Visible = true;
                            break;
                        case 'e':
                            btnE.Visible = true;
                            break;
                        case 'f':
                            btnF.Visible = true;
                            break;
                        case 'g':
                            btnG.Visible = true;
                            break;
                        case 'h':
                            btnH.Visible = true;
                            break;
                        case 'i':
                            btnI.Visible = true;
                            break;
                        case 'j':
                            btnJ.Visible = true;
                            break;
                        case 'k':
                            btnK.Visible = true;
                            break;
                        case 'l':
                            btnL.Visible = true;
                            break;
                        case 'm':
                            btnM.Visible = true;
                            break;
                        case 'n':
                            btnN.Visible = true;
                            break;
                        case 'o':
                            btnO.Visible = true;
                            break;
                        case 'p':
                            btnP.Visible = true;
                            break;
                        case 'q':
                            btnQ.Visible = true;
                            break;
                        case 'r':
                            btnR.Visible = true;
                            break;
                        case 's':
                            BtnS.Visible = true;
                            break;
                        case 't':
                            BtnT.Visible = true;
                            break;
                        case 'u':
                            btnU.Visible = true;
                            break;
                        case 'v':
                            btnV.Visible = true;
                            break;
                        case 'w':
                            btnW.Visible = true;
                            break;
                        case 'x':
                            btnX.Visible = true;
                            break;
                        case 'y':
                            btnY.Visible = true;
                            break;
                        case 'z':
                            btnZ.Visible = true;
                            break;
                    }
                }
                catch(Exception ex)
                {
                    cities.RemoveAt(i); //if there is an exception then the city that caused it will be removed. 
                }
               
            }
            count++;            
        }
      
        

        public address()
        {
            InitializeComponent();
        }


        //below is the click events for all the letters and the space bar.
        private void btnA_Click(object sender, EventArgs e)
        {
           
            string a = "a";
            tb_address.Text += a;
            checkStreet();
            hide();
            showLetter();


        }

        private void btnB_Click(object sender, EventArgs e)
        {
            string b = "b";
            tb_address.Text += b;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            string c = "c";
            tb_address.Text += c;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            string d = "d";
            tb_address.Text += d;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnE_Click(object sender, EventArgs e)
        {
            string ex = "e";
            tb_address.Text += ex;
            checkStreet();
            hide();
            showLetter();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            string f = "f";
            tb_address.Text += f;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnG_Click(object sender, EventArgs e)
        {
            string g = "g";
            tb_address.Text += g;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnH_Click(object sender, EventArgs e)
        {
            string h = "h";
            tb_address.Text += h;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnI_Click(object sender, EventArgs e)
        {
            string i = "i";
            tb_address.Text += i;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            string j = "j";
            tb_address.Text += j;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnK_Click(object sender, EventArgs e)
        {
            string k = "k";
            tb_address.Text += k;
            checkStreet();
            hide();
            showLetter();
            ;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            string l = "l";
            tb_address.Text += l;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnM_Click(object sender, EventArgs e)
        {
            string m = "m";
            tb_address.Text += m;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnN_Click(object sender, EventArgs e)
        {
            string n = "n";
            tb_address.Text += n;
            checkStreet();
            hide();
            showLetter();
            ;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            string o = "o";
            tb_address.Text += o;
            checkStreet();
            hide();
            showLetter();
            ;
        }
        private void btnP_Click(object sender, EventArgs e)
        {
            string p = "p";
            tb_address.Text += p;
            checkStreet();
            hide();
            showLetter();

        }
        private void btnQ_Click(object sender, EventArgs e)
        {
            string q = "q";
            tb_address.Text += q;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnR_Click(object sender, EventArgs e)
        {
            string r = "r";
            tb_address.Text += r;
            checkStreet();
            hide();
            showLetter();
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            string s = "s";
            tb_address.Text += s;
            checkStreet();
            hide();
            showLetter();

        }

        private void BtnT_Click(object sender, EventArgs e)
        {
            string t = "t";
            tb_address.Text += t;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnU_Click(object sender, EventArgs e)
        {
            string u = "u";
            tb_address.Text += u;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnV_Click(object sender, EventArgs e)
        {
            string v = "v";
            tb_address.Text += v;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnW_Click(object sender, EventArgs e)
        {
            string w = "w";
            tb_address.Text += w;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            string x = "x";
            tb_address.Text += x;
            checkStreet();
            hide();
            showLetter(); 
            
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            string y = "y";
            tb_address.Text += y;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            string z = "z";
            tb_address.Text += z;
            checkStreet();
            hide();
            showLetter();

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            citiesForm citiesform = new citiesForm();
            citiesform.Show();
            this.Close();
        }
        private void btnSpace_Click(object sender, EventArgs e)
        {
            string space = " ";
            tb_address.Text += space;
            checkStreet();
            hide();
            showLetter();
        }

        private void address_Load(object sender, EventArgs e) //this will load when the address form loads. this code will open a connection ot the database and then run the query we want it to run
        {
            citiesForm cityForm = new citiesForm();
            connection.Open(); //this will open the connection to the access database
            OleDbCommand command = new OleDbCommand(); //this will give a command to the access database
            command.Connection = connection; //now the command knows what the connection information is.
            string commandString = "SELECT * FROM Addresses WHERE [City] ='" + citiesForm.city + "'";
            command.CommandText = commandString; //this declares what query we want to execute;
            OleDbDataReader reader = command.ExecuteReader();
           

            while (reader.Read()) //we read through the information in the database
            {
                cities.Add(reader.GetString(2)); //we all the cities that were in the state into a list. GetString(2) gets the select element, which is cities in the database
               
            }
            connection.Close(); //close the connection since we have all the data we need 
        }
        private void btnA_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
       
        public void hide()
        {
            btnA.Visible = false;
            btnB.Visible = false;
            btnC.Visible = false;
            btnD.Visible = false;
            btnE.Visible = false;
            btnF.Visible = false;
            btnG.Visible = false;
            btnH.Visible = false;
            btnI.Visible = false;
            btnJ.Visible = false;
            btnK.Visible = false;
            btnL.Visible = false;
            btnM.Visible = false;
            btnN.Visible = false;
            btnO.Visible = false;
            btnP.Visible = false;
            btnQ.Visible = false;
            btnR.Visible = false;
            BtnS.Visible = false;
            BtnT.Visible = false;
            btnU.Visible = false;
            btnV.Visible = false;
            btnW.Visible = false;
            btnX.Visible = false;
            btnY.Visible = false;
            btnZ.Visible = false;
        } //this is the method with the logic to hide ALL letters. The logic to show letters is in the method show letters. 
         
        private void btnAddressSubmit_Click(object sender, EventArgs e)  //the submit button logic. Makes current form invisible and then opens the next form. 
        {
            street =  tb_address.Text.ToString().ToLower();
            this.Visible = false;
            finalForm final = new finalForm();
            final.Show();
        }

        
    }
}
