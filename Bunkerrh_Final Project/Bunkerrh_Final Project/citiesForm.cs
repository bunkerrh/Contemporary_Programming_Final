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
    public partial class citiesForm : Form
    {
        public citiesForm()
        {
            InitializeComponent();
        }

       
        public static string city { get; set; }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                                                        "Data Source= ../addressDatabase.accdb"); //the oledb connection and connection string make sure to add using System.Data.OleDB
        //the global variables for the form
        public List<string> cities = new List<string>();
        int count = 1;
        int streetCount = 1;

        //the logic to check the street names. It will take the first n letters of everystreet from data base 
        // and check them against the letters entered. Removes any cities that do not match
        private void checkStreet() 
        {
            
            string tempLetters;
            int citiesCount = cities.Count; //since the size of cities will count as we remove stuff from the list we need a number that wont change

            for (int i = citiesCount - 1; i >= 0; i--)
            {
                tempLetters = cities[i].Substring(0, streetCount).ToLower();
                if (tempLetters != tb_city.Text.ToString())
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

                    string temp = cities[i].ToLower(); ;
                    char letter = temp[count];
                    switch (letter)
                    {
                        case ' ':
                            btn_Space.Visible = true;
                            break;
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
                catch (Exception ex) //if there is an exception removes the city that caused it. THis was built mainly for an earlier build of the project. 
                {
                    cities.RemoveAt(i);
                }

            }
            count++;
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
            btn_Space.Visible = false;
        }

        //click events for the keyboard
        private void btnA_Click(object sender, EventArgs e)
        {

            string a = "a";
            tb_city.Text += a;
            checkStreet();
            hide();
            showLetter();


        }

        private void btnB_Click(object sender, EventArgs e)
        {
            string space = "b";
            tb_city.Text += space;
            checkStreet();
            hide();
            showLetter();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            string c = "c";
            tb_city.Text += c;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            string d = "d";
            tb_city.Text += d;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnE_Click(object sender, EventArgs e)
        {
            string ex = "e";
            tb_city.Text += ex;
            checkStreet();
            hide();
            showLetter();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            string f = "f";
            tb_city.Text += f;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnG_Click(object sender, EventArgs e)
        {
            string g = "g";
            tb_city.Text += g;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnH_Click(object sender, EventArgs e)
        {
            string h = "h";
            tb_city.Text += h;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnI_Click(object sender, EventArgs e)
        {
            string i = "i";
            tb_city.Text += i;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            string j = "j";
            tb_city.Text += j;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnK_Click(object sender, EventArgs e)
        {
            string k = "k";
            tb_city.Text += k;
            checkStreet();
            hide();
            showLetter();
            ;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            string l = "l";
            tb_city.Text += l;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnM_Click(object sender, EventArgs e)
        {
            string m = "m";
            tb_city.Text += m;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnN_Click(object sender, EventArgs e)
        {
            string n = "n";
            tb_city.Text += n;
            checkStreet();
            hide();
            showLetter();
            ;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            string o = "o";
            tb_city.Text += o;
            checkStreet();
            hide();
            showLetter();
            ;
        }
        private void btnP_Click(object sender, EventArgs e)
        {
            string p = "p";
            tb_city.Text += p;
            checkStreet();
            hide();
            showLetter();

        }
        private void btnQ_Click(object sender, EventArgs e)
        {
            string q = "q";
            tb_city.Text += q;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnR_Click(object sender, EventArgs e)
        {
            string r = "r";
            tb_city.Text += r;
            checkStreet();
            hide();
            showLetter();
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            string s = "s";
            tb_city.Text += s;
            checkStreet();
            hide();
            showLetter();

        }

        private void BtnT_Click(object sender, EventArgs e)
        {
            string t = "t";
            tb_city.Text += t;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnU_Click(object sender, EventArgs e)
        {
            string u = "u";
            tb_city.Text += u;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnV_Click(object sender, EventArgs e)
        {
            string v = "v";
            tb_city.Text += v;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnW_Click(object sender, EventArgs e)
        {
            string w = "w";
            tb_city.Text += w;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            string x = "x";
            tb_city.Text += x;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnY_Click(object sender, EventArgs e)
        {
            string y = "y";
            tb_city.Text += y;
            checkStreet();
            hide();
            showLetter();

        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            string z = "z";
            tb_city.Text += z;
            checkStreet();
            hide();
            showLetter();

        }


        private void btn_Space_Click(object sender, EventArgs e)
        {
            string space = " ";
            tb_city.Text += space;
            checkStreet();
            hide();
            showLetter();
        }

        private void btnAddressSubmit_Click(object sender, EventArgs e)
        {
            city = tb_city.Text.ToString().ToLower();
            this.Visible = false;
            address addressForm = new address();
            addressForm.Show();
        }

        private void citiesForm_Load(object sender, EventArgs e)
        {
            stateForm stateForm = new stateForm();
            connection.Open(); //this will open the connection to the access database
            OleDbCommand command = new OleDbCommand(); //this will give a command to the access database
            command.Connection = connection; //now the command knows what the connection information is.
            string commandString = "SELECT * FROM Addresses WHERE [State ab] ='" + stateForm.selectedState + "'";
            command.CommandText = commandString; //this declares what query we want to execute;
            OleDbDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                cities.Add(reader.GetString(4));

            }


            connection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            addressNumber addressNumber = new addressNumber();
            addressNumber.Show();
            this.Close();
        }
    }
}
