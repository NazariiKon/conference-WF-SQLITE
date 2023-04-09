using System.Data.SQLite;
using System.Drawing;
using System.Globalization;

namespace conferencesProject
{
    public partial class Form1 : Form
    {
        private SQLiteConnection _con;

        public Form1()
        {
            InitializeComponent();
            string query = "SELECT * from Conference";
            List<Conference> conferences = new List<Conference>();

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
                            conferences.Add(new Conference(
                            reader.GetInt32(0), // Id
                            reader.GetString(1), // DateFirstMessage
                            reader.GetString(2), // DateReceiptApplication
                            reader.GetString(3), // Topic
                            reader.GetString(4), // MarkingReceiptAbstracts
                            reader.GetString(5), // DateSecondMessage
                            reader.GetString(6), // DateReceiptRegistrationFee
                            reader.GetInt32(7), // AmountOrganisationalContributionReceived
                            reader.GetString(8), // DateArrival
                            reader.GetString(9), // DateDeparture
                            reader.GetString(10) // Hotel
                            ));
                        }
                    }
                }
                _con.Close();
            }
            conferencesListBox.ValueMember = "Info";
            conferencesListBox.Items.AddRange(conferences.ToArray());
        }

        private void conferencesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form2 newForm2 = new Form2((Conference)conferencesListBox.SelectedItem);
            newForm2.Show();
        }
    }
}