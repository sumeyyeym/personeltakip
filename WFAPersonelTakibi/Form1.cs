using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFAPersonelTakibi
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDepartment.Items.AddRange(Enum.GetNames(typeof(Department)));
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.Adi = txtFirstName.Text;
            p.SoyAdi = txtLastName.Text;
            p.Adres = txtAddress.Text;
            p.Departman = (Department)Enum.Parse(typeof(Department), cmbDepartment.Text);
            p.DogumTarihi = dtBirthDate.Value;
            p.Mail = txtMail.Text;
            p.Telefon = txtPhone.Text;

            if (rdFemale.Checked)
            {
                p.Cinsiyet = Gender.Female;
            }
            else if (rdMale.Checked)
            {
                p.Cinsiyet = Gender.Male;
            }
            else if (rdRandom.Checked)
            {
                p.Cinsiyet = Gender.Karışık;
            }
        }
    }
}
