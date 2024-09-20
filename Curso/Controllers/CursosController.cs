using Microsoft.AspNetCore.Mvc;
using Curso.Models; // Certifique-se de que está importando o namespace correto
using System.Collections.Generic;

namespace Curso.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            var cursos = new List<Curso>
            {
                new Curso { Id = 1, Nome = "Inglês Básico", Descricao = "Curso de inglês para iniciantes.", Preco = 299.99M },
                new Curso { Id = 2, Nome = "Inglês Intermediário", Descricao = "Curso de inglês para nível intermediário.", Preco = 399.99M }
            };

            return View(cursos);
        }

        public IActionResult Detalhes(int id)
        {
            var cursos = new List<Curso>
            {
                new Curso { Id = 1, Nome = "Inglês Básico", Descricao = "Curso de inglês para iniciantes.", Preco = 299.99M },
                new Curso { Id = 2, Nome = "Inglês Intermediário", Descricao = "Curso de inglês para nível intermediário.", Preco = 399.99M }
            };

            var curso = cursos.Find(c => c.Id == id);
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);
        }
    }
}
