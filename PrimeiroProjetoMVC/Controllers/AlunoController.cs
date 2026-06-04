using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uninove.web.Models;

namespace PrimeiroProjetoMVC.Controllers;
public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Guilherme";
        ViewBag.Curso = "ADS";
        ViewBag.Semestre = "Primeiro-Semestre";
        return View();
    }

    public IActionResult Detalhes(int id)
    {
        ViewBag.Alunoid = id;
        return View();
    }
}