using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace PrimeiroProjetoMVC.Controllers;
public class AlunoController : Controller
{
    public IActionResult index()
    {
        ViewBag.Nome = "Guilherme";
        ViewBag.Curso = "ADS";
        ViewBag.Semestre = "Primeiro-Semestre";
        return View();
    }

    public IActionResult detalhes(int id)
    {
        ViewBag.Alunoid = id;
        return View();
    }
}