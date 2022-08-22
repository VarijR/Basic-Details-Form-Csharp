using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class LakeSuperior : Form
    {
        public LakeSuperior()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            //get input from the user
            string email = txtEmail.Text.Trim();
            //input validation
            if (email.IndexOf("@") == -1)
            {
                MessageBox.Show("Invalid email.", "Input Error");
            }
            else
            {
                //get index of @
                int index = email.IndexOf("@");
                //get username
                string username = email.Substring(0, index);
                //get domain
                string domain = email.Substring(index + 1);
                //display message
                MessageBox.Show("User name: " + username + "\nDomain name: " + domain, "Parsed String");
            }
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string formattedString = "";
            //formatting city, state and zip code
            formattedString = txtCity.Text.Trim() + txtState.Text.Trim().ToUpper() + txtZipCode.Text.Trim();
            formattedString = formattedString.Insert(txtCity.Text.Trim().Length, ", ");
            int index = formattedString.Length - txtZipCode.Text.Trim().Length;
            formattedString = formattedString.Insert(index, " ");
            //display message
            MessageBox.Show("City, State, Zip: " + formattedString, "Formatted String");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}