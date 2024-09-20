using Curso_de_idiomas.Models;
using Microsoft.AspNetCore.Mvc;

public class CursosController : Controller
{
    public IActionResult Index()
    {
        var cursos = new List<Curso>
        {
            new Curso { Id = 1, Nome = "Inglês Básico", Descricao = "Curso de inglês para iniciantes.", Preco = 299.99M },
            new Curso { Id = 2, Nome = "Inglês Intermediário", Descricao = "Curso de inglês para nível intermediário.", Preco = 399.99M }
        };

        // Certifique-se de que está retornando a lista de cursos para a view
        return View(cursos);
    }
}
