namespace PassingMultipleObjectsToRazorPage.Models {
    public class Player : IPlayer {
        public int PlayerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Position { get; set; }
    }
}
