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

namespace WindowsFormsApplication1
{
    public partial class search : UserControl
    {

        private GymEntities entities;
        //initializarea db in constructor
        public search()
        {
            InitializeComponent();
            entities = new GymEntities();
        }


        private void namelabel_Click(object sender, EventArgs e)
        {

        }

        private void sexlabel_Click(object sender, EventArgs e)
        {

        }

        private void packagelabel_Click(object sender, EventArgs e)
        {

        }

        private void datelabel_Click(object sender, EventArgs e)
        {

        }

        //Metoda cautarii dupa nume
        private Member searchByName(string name)
        {
            //Va lua membrul al carui nume este la fel cu cel din tabelul membri
            var member = (from p in entities.Members
                          where p.Member_Name == name
                          select p).FirstOrDefault();
            //Returneaza membrul
            return member;
        }
        //metoda cautarii dupa id
        private Member searchById(string id)
        {
            //Aceasta metoda este mai folositoare deoarece numele pot fi duplicate, id-urile nu
            var member = (from p in entities.Members
                          where p.Member_ID == id
                          select p).FirstOrDefault();
            return member;
        }
        //pastreaza membrul in caz ca vreau sa-l sterg
        private Member memberToBeDeletedInCase = null;
        private void button1_Click(object sender, EventArgs e)
        {
            Member member = null;
            //daca id este null, va cauta dupa nume
            if (!string.IsNullOrEmpty(IDtextbox.Text))
            {
                member = searchById(IDtextbox.Text);
                memberToBeDeletedInCase = member;
            }
            //daca nume este null, va cauta dupa id
            else if (!string.IsNullOrEmpty(nametextbox.Text))
            {
                member = searchByName(nametextbox.Text);
                memberToBeDeletedInCase = member;
            }
            else
                MessageBox.Show("Please Enter one of Search Criteria", "Error", MessageBoxButtons.OK);
            //Setează valorile din labels
            if (member != null)
            {
                namelabel.Text = member.Member_Name;
                sexlabel.Text = member.Member_sex;
                datelabel.Text = member.Member_Date.ToString();
                packagelabel.Text = member.Package_ID;
                groupBox1.Visible = true;
            }

        }




        private void IDtextbox_MouseClick(object sender, MouseEventArgs e)
        {
            nametextbox.Text = null;
        }

        private void nametextbox_MouseClick(object sender, MouseEventArgs e)
        {
            IDtextbox.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //se sterge membrul cand apesi delete
            entities.Members.Remove(memberToBeDeletedInCase);
            entities.SaveChanges();
            MessageBox.Show("Member's Registration has been deleted", "Success", MessageBoxButtons.OK);
        }
    }
}
