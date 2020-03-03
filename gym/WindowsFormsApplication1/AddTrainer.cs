using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddTrainer : UserControl
    {
        public AddTrainer()
        {
            InitializeComponent();
            entities = new GymEntities();
        }

        private GymEntities entities;
        //Adaugare antrenor
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            //se creeaza o noua instanta in tabelul antrenori
            Trainer trainer = new Trainer()
            {
                Trainer_ID = new Random().Next(1, 100000).ToString(),
                Trainer_Address = txbx_address.Text,
                Trainer_Name = txbx_name.Text,
                Trainer_PhoneNumber = txbx_contact.Text
            };
            //Se adauga in baza de date
            entities.Trainers.Add(trainer);
            //Salvare
            entities.SaveChanges();
            MessageBox.Show("Trainer has been Added", "Success", MessageBoxButtons.OK);
            //Refresh formular
            Form1 form = new Form1();
            ((Form1)this.TopLevelControl).Close();
            form.Show();
        }

        private void AddTrainer_Load(object sender, EventArgs e)
        {

        }
    }
}
