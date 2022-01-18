using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;
using MvcProject.Repository;

namespace MvcProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IMockUserRepository _mockUserRepository;

    public HomeController(ILogger<HomeController> logger, IMockUserRepository mockUserRepository)
    {
        _logger = logger;
        _mockUserRepository = mockUserRepository;

    }

    public IActionResult Index()
    {
        return View(_mockUserRepository.GetAll());
    }

    /// <summary>
    /// Gets the user with the specified id and displays a view with all their details
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public ActionResult Details(int id)
    {
        // TODO: Get the correct user
        Models.MockUser user = null;

        return View(user);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
