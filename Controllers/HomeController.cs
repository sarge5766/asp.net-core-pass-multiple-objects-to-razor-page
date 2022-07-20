using Microsoft.AspNetCore.Mvc;
using PassingMultipleObjectsToRazorPage.Models;
using System.Diagnostics;
using System.Dynamic;

namespace PassingMultipleObjectsToRazorPage.Controllers; 
public class HomeController : Controller {
    private readonly ILogger<HomeController> _logger;

    private readonly ITeam _team;
    private readonly IPlayer _player;

    private readonly dynamic model;

    public HomeController(ILogger<HomeController> logger, IPlayer player, ITeam team) {
        _logger = logger;
        _player = player;
        _team = team;

        PopulatePlayerModel();
        PopulateTeamModel();

        model = new ExpandoObject();
        model.Team = _team;
        model.Player = _player;
    }

    public IActionResult Index() {
        return View(model);
    }

    public IActionResult Privacy() {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private void PopulateTeamModel() {
        _team.TeamId = 1;
        _team.TeamName = "Boston Red Sox";
    }

    private void PopulatePlayerModel() {
        _player.PlayerId = 1;
        _player.Position = "Center Field";
        _player.FirstName = "Fred";
        _player.LastName = "Lynn";
    }
}