namespace conferencesProject
{
    public class People
    {
        public People(int id, string name, string surname, string academicDegree, string academicTitle, string researchArea,
        string placeWork, string position, string country, int postalCode, string address, string phone, string homePhone, string email)
        {
            Id = id;
            Name = name;
            Surname = surname;
            AcademicDegree = academicDegree;
            AcademicTitle = academicTitle;
            ResearchArea = researchArea;
            PlaceWork = placeWork;
            Position = position;
            Country = country;
            PostalCode = postalCode;
            Address = address;
            Phone = phone;
            HomePhone = homePhone;
            Email = email;
            Info = name + " " + surname;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AcademicDegree { get; set; }
        public string AcademicTitle { get; set; }
        public string ResearchArea { get; set; }
        public string PlaceWork { get; set; }
        public string Position { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }
        public string Info { get; set; }
    }
}