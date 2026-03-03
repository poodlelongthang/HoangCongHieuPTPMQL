namespace PTPMQL_MVC.Controllers;

using Microsoft.AspNetCore.Mvc;
using PTPMQL_MVC.Models.Entities;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
[HttpPost]
    public IActionResult Index(string StudentCode, string FullName)
    {
        ViewBag.Message = StudentCode + FullName;
        return View();
    }
}