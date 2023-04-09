using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conferencesProject
{
    public partial class Form2 : Form
    {
        private SQLiteConnection _con;

        public Form2(Conference conference)
        {
            InitializeComponent();
            List<People> users = new List<People>();

            string query = "SELECT User.* " +
                "FROM User " +
                "JOIN ConferenceUsers ON User.Id = ConferenceUsers.UserId " +
                "WHERE ConferenceUsers.ConferenceId = " + conference.Id;

            using (_con = new SQLiteConnection(@"Data Source=conferences.db"))
            {
                _con.Open();
                SQLiteCommand command = new SQLiteCommand(query, _con);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            users.Add(new People(
                             reader.GetInt32(0), // Id
                             reader.GetString(1), // Name
                             reader.GetString(2), // Surname
                             reader.GetString(3), // AcademicDegree
                             reader.GetString(4), // AcademicTitle
                             reader.GetString(5), // ResearchArea
                             reader.GetString(6), // PlaceWork
                             reader.GetString(7), // Position
                             reader.GetString(8), // Country
                             reader.GetInt32(9), // PostalCode
                             reader.GetString(10), // Address
                             reader.GetString(11), // Phone
                             reader.GetString(12), // HomePhone
                             reader.GetString(13) // Email
                            ));
                        }
                    }
                }
            }
            usersListBox.ValueMember = "Info";
            usersListBox.Items.AddRange(users.ToArray());

            // Заполнение textBox
            textBoxTopic.Text = conference.Topic.ToString();
            textBoxNote.Text = conference.MarkingReceiptAbstracts.ToString();
            textBoxAmount.Text = conference.AmountOrganisationalContributionReceived.ToString();

            // Заполнение datePicker
            dateTimePickerFirstReminder.Value = DateTime.Parse(conference.DateFirstMessange.ToString());
            dateTimePickerSecondReminder.Value = DateTime.Parse(conference.DateSecondMessage.ToString());

            dateTimePickerReceipt.Value = DateTime.Parse(conference.DateReceiptApplication.ToString());
            dateTimePickerDue.Value = DateTime.Parse(conference.DateReceiptRegistrationFee.ToString());
            dateTimePickerArrival.Value = DateTime.Parse(conference.DateArrival.ToString());
            dateTimePickerDeparture.Value = DateTime.Parse(conference.DateDeparture.ToString());
        }

        private void usersListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form3 newForm3 = new Form3((People)usersListBox.SelectedItem);
            newForm3.Show();
        }
    }
}
