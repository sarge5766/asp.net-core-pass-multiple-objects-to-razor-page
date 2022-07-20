namespace PassingMultipleObjectsToRazorPage.Models {
    public class Team : ITeam {
        public int TeamId { get; set; }
        public string? TeamName { get; set; }
    }
}
