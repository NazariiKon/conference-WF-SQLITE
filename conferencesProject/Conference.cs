namespace conferencesProject
{
    public class Conference
    {
        public Conference(int id, object dateFirstMessange, object dateReceiptApplication, object topic, object markingReceiptAbstracts, object dateSecondMessage, object dateReceiptRegistrationFee, object amountOrganisationalContributionReceived, object dateArrival, object dateDeparture, object hotel)
        {
            Id = id;
            DateFirstMessange = dateFirstMessange;
            DateReceiptApplication = dateReceiptApplication;
            Topic = topic;
            MarkingReceiptAbstracts = markingReceiptAbstracts;
            DateSecondMessage = dateSecondMessage;
            DateReceiptRegistrationFee = dateReceiptRegistrationFee;
            AmountOrganisationalContributionReceived = amountOrganisationalContributionReceived;
            DateArrival = dateArrival;
            DateDeparture = dateDeparture;
            Hotel = hotel;
            Info = dateFirstMessange + " " + topic;
        }

        public int Id { get; set; }
        public object DateFirstMessange { get; set; }
        public object DateReceiptApplication { get; set; }
        public object Topic { get; set; }
        public object MarkingReceiptAbstracts { get; set; }
        public object DateSecondMessage { get; set; }
        public object DateReceiptRegistrationFee { get; set; }
        public object AmountOrganisationalContributionReceived { get; set; }
        public object DateArrival { get; set; }
        public object DateDeparture { get; set; }
        public object Hotel { get; set; }
        public string Info { get; set; }
    }
}