﻿namespace CarRentalManagement.Components.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set; }
        public string? LiscensePlateNumber { get; set; }
        public int MakeId  { get; set; }
        public int ModelId { get; set; }
        public int ColourId { get; set; }
    }
}
