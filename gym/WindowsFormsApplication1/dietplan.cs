using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class dietplan : UserControl
    {
        public dietplan()
        {
            InitializeComponent();
            entites = new GymEntities();
        }

        private GymEntities entites;

        //adaugare dietplan la membri
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            //setarea numelor dietplan dupa butoane
            string DietPlan = " ";
            if (rdplan1.Checked == true)
                DietPlan = "Diet Plan 1";
            else if (rdPlan2.Checked == true)
                DietPlan = "Diet Plan 2";
            else if (rdplan3.Checked == true)
                DietPlan = "Diet Plan 3";

            //ia id-ul de la diet plan dupa selectarea facuta
            string dietPlan = (from plan in entites.Diet_Plans
                               where plan.PlanName == DietPlan
                               select plan.PlanID).FirstOrDefault();
            //retine numele ales in combobox
            string MemberName = comboBox1.Text;
            //se alege un membru existent in baza de date
            var selectedMember = (from member in entites.Members
                                  where member.Member_Name == MemberName
                                  select member).FirstOrDefault();
            //Seteaza alegerea facuta
            selectedMember.DietPlanID = dietPlan;
            //Salvare
            entites.SaveChanges();
            MessageBox.Show("Diet Plan Updated", "Success", MessageBoxButtons.OK);
        }

        private void RdPlan2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoadNames(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            SqlCommand command;

            //Connection string
            connetionString = @"Data Source=.;Initial Catalog=Gym;Integrated Security=true";
            //Query pentru selectarea membrilor
            string query = "SELECT * FROM dbo.Members";
            //Initializare conexiune
            cnn = new SqlConnection(connetionString);
            //pornire conexiune
            cnn.Open();
            //
            command = new SqlCommand(query, cnn);
            //se executa citirea. va vedea toate randurile din tabela membri
            var reader = command.ExecuteReader();
            //cauta si retine coloana ceruta din tabelul membri
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Member_Name"].ToString());
            }
            command.Dispose();
            //close si dispose pentru conexiune sunt necesare
            cnn.Close();
        }
    }
}
