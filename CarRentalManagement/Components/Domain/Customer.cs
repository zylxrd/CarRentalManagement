namespace CarRentalManagement.Components.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? DrivingLiscense { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? EmailAddress { get; set; }
    }
}
