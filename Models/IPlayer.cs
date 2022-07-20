namespace PassingMultipleObjectsToRazorPage.Models {
    public interface IPlayer {
        string? FirstName { get; set; }
        string? LastName { get; set; }
        int PlayerId { get; set; }
        string? Position { get; set; }
    }
}