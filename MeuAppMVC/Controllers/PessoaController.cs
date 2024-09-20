using Microsoft.AspNetCore.Mvc;

public class PessoaController : Controller
{
    private static List<Pessoa> pessoas = new List<Pessoa>();
    private static int idCounter = 1;

    public ActionResult Index()
    {
        return View("~/Views/Home/Index.cshtml", pessoas);
    }

    public ActionResult Criar()
    {
        return View("~/Views/Home/Criar.cshtml");
    }

    [HttpPost]
    public ActionResult Criar(Pessoa pessoa)
    {
        if (ModelState.IsValid)
        {
            pessoa.Id = idCounter++;
            pessoas.Add(pessoa);
            return RedirectToAction("Index");
        }
        return View("~/Views/Home/Criar.cshtml", pessoa);
    }
}