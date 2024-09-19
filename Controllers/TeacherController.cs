using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Third_Web_api.Models;

namespace Third_Web_api.Controllers;

public class TeacherController : Controller
{
    public IActionResult details()
    {
        //data passing to the view folder
        //ViewData[key]=valu
        ViewData["websitename"] = "My first website create";
        ViewData["name"] = "Fahim";
        ViewData["number"] = 0187673643;
        ViewData["salary"] = 20000.000;

        ViewData["Programming"] = new List<string> { "PHP", "C#", "html", "CSS" };


        // models theke data niya kje kora
        Teacher teacher = new Teacher()
        {
           Id = 1,
           TeacherName = "Fahim",
           SubjecName = "Programming in java"

        };

        ViewData["Tecr"] = teacher;


        return View();
    }

}
