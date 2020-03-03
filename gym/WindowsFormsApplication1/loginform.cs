using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class loginform : Form
    {

        //The GymEntities is the database instance that we are going to work with
        private GymEntities entites = new GymEntities();

        //This added by variable would be used in the add member form to know who entered the member
        public static string AddedBy = "";
        //Constructor
        public loginform()
        {
            InitializeComponent();
        }

        //Button Click Event
        private void button1_Click(object sender, EventArgs e)
        {
            //acest query ia informatia din baza de date
            //va returna doar daca informatia introdusa corespunde cu cea din baza de date
           //username unici
            //Username e cheie primara
            var UserInformation = (from user in entites.Users
                                   where user.Username == txbx_username.Text && user.Password == txbx_password.Text
                                   select user).FirstOrDefault();
           
            //compara informatia primita cu informatia introdusa in textbox
            if (UserInformation != null)
            {
                AddedBy = UserInformation.Username;
                //afiseaza noul form
                Form1 f1 = new Form1();
                this.Hide();
                f1.ShowDialog();
            }
            else
                MessageBox.Show("Incorrect Login Information", "Sign in Error", MessageBoxButtons.RetryCancel);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
