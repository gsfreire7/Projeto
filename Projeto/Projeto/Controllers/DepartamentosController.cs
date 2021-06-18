using Microsoft.AspNetCore.Mvc;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Models;

namespace Projeto.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> lista = new List<Departamento>();
            lista.Add(new Departamento { Id = 1, Nome = "Jogos Eletrônicos" });
            lista.Add(new Departamento { Id = 2, Nome = "Futebol" });
            return View(lista);
        }
    }
}
