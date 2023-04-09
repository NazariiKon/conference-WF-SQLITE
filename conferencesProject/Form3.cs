using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conferencesProject
{
    public partial class Form3 : Form
    {
        public Form3(People user)
        {
            InitializeComponent();

            textBoxName.Text = user.Name;
            textBoxSurname.Text = user.Surname;
            textBoxAcademicDegree.Text = user.AcademicDegree;
            textBoxAcademicTitle.Text = user.AcademicTitle;
            textBoxResearchArea.Text = user.ResearchArea;
            textBoxPlaceWork.Text = user.PlaceWork;
            textBoxPosition.Text = user.Position;
            textBoxCountry.Text = user.Country;
            textBoxPostalCode.Text = user.PostalCode.ToString();
            textBoxAddress.Text = user.Address;
            textBoxPhone.Text = user.Phone.ToString();
            textBoxHomePhone.Text = user.HomePhone.ToString();
            textBoxEmail.Text = user.Email;
        }

    }
}
