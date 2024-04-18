namespace cs6232_g4.Model

{
    /// <summary>
    /// Holds the elements of the admin report
    /// </summary>
    public class AdminReport
    {
        public int FurnitureId { get; set; }

        public string Name { get; set; }

        public string CategoryName { get; set; }

        public int TotalRentalsOfInterest { get; set; }

        public int TotalTransactions { get; set; }

        public int PctOfQualifyingTransactions { get; set; }

        public int PctOfMembers18To29 { get; set; }

        public int PctOfRemainingMembers {  get; set; }

    }
}
