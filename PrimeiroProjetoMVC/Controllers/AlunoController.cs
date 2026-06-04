using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
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

    public IActionResult Sobre()
    {
        ViewBag.Sobre = "ASP.NET Core MVC Criado pela Microsoft";
        return View();
    }
}