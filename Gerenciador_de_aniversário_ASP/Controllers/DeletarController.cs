using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador_de_aniversário_ASP.Controllers
{
    public class DeletarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}