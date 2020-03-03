using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class newmember : UserControl
    {
        //se initializeaza instanta bazei de date
        public newmember()
        {
            InitializeComponent();
            entities = new GymEntities();
        }

        private GymEntities entities;

        private void button1_Click(object sender, EventArgs e)
        {
           




        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Adaugarea membrului
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            //retine abonamentul selectat
            string comboxBoxPackagesText = cmbx_package.Text;
            // Atribuirea codurilor conform bazei de date prin utilizarea structurilor de control
            if (cmbx_package.Text == "Monthly")
                comboxBoxPackagesText = "1";
            else if (cmbx_package.Text == "3 Months")
                comboxBoxPackagesText = "3";
            else if (cmbx_package.Text == "6 Months")
                comboxBoxPackagesText = "6";
            else if (cmbx_package.Text == "1 Year")
                comboxBoxPackagesText = "12";
            //Se ia cheia primară din packages cu interogare in baza de date
            var getPackagesID = (from package in entities.Packages
                                 where package.Package_Time == comboxBoxPackagesText
                                 select new { package.Package_ID, package.Package_Time }).FirstOrDefault();
            //selecteaza genul
            string gender = " ";
            if (malerb.Checked == true)
                gender = "Male";
            else if (femalrb.Checked == true)
                gender = "Female";
            string getTrainerID = " ";
            //Retine numele antrenorului
            string trainerSelected = cmbx_Trainer.Text;
            //Se ia id-ul din tabelul Trainer, după numele selectat
            getTrainerID = (from trainer in entities.Trainers
                            where trainer.Trainer_Name == trainerSelected
                            select trainer.Trainer_ID).FirstOrDefault();

            //se creeaza o noua instanta membru si se atribuie valori
            Member member = new Member()
            {
                Member_ID = new Random().Next(1, 100000000).ToString(),
                Member_Date = dateTimePicker2.Value.Date.ToShortDateString(),
                Member_Name = namebox.Text.Trim(),
                Member_sex = gender,
                Package_ID = getPackagesID.Package_ID,
                Member_PackageExpiry = dateTimePicker1.Value.Date.AddMonths(int.Parse(getPackagesID.Package_Time)),
                Member_Email = emailbox.Text.Trim(),
                AddedBy = loginform.AddedBy,
                Trainer_ID = getTrainerID
            };

            //Se adauga in baza de date
            entities.Members.Add(member);
            //Call la save changes pentru a da update la database
            entities.SaveChanges();
            MessageBox.Show("Member has been Added Successfully", "Added", MessageBoxButtons.OK);
            //Refresh la form pentru a vedea updateul
            Form1 form = new Form1();
            ((Form1)this.TopLevelControl).Close();
            form.Show();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            SqlCommand command;
            //conexiunea la baza de date
            connetionString = @"Data Source=.;Initial Catalog=Gym;Integrated Security=true";
            string query = "SELECT * FROM dbo.Trainer";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            command = new SqlCommand(query, cnn);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbx_Trainer.Items.Add(reader["Trainer_Name"].ToString());
            }
            command.Dispose();
            cnn.Close();
        }
        private static void SendEmail(Member member)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress("FromMailAddress");//adresa mea de email
            message.To.Add(new MailAddress(member.Member_Email));
            message.Subject = "Test";
            message.IsBodyHtml = true; //crează body-ul emailului html  
            message.Body = "Test Email";
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com"; 
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("Address", "password");//Credentialele e-mailului
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }

        private void CheckExpiries()
        {
            var members = (from p in entities.Members
                           select p).ToList();
            foreach (var item in members)
            {
                if (item.Member_PackageExpiry.Value.Month > DateTime.Now.Month)
                    SendEmail(item);
            }
        }

        private System.Timers.Timer ExpiryCheckTimer;
        private void ExpiryCheckTime()
        {
            //24 * 60 * 60 * 1000
            ExpiryCheckTimer = new System.Timers.Timer(86400 * 1000);
            ExpiryCheckTimer.Elapsed += ExpiryCheckTimer_Elapsed;
            ExpiryCheckTimer.AutoReset = true;
            ExpiryCheckTimer.Enabled = true;
        }

        private void ExpiryCheckTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            CheckExpiries();
        }
    }
}
