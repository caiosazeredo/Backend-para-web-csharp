using Microsoft.AspNetCore.Mvc;

namespace aula_11.Controllers
{
    public class TarefaController : Controller
    {
        // Simulando um banco de dados em memória
        private static List<Tarefa> tarefas = new List<Tarefa>
        {
            new Tarefa { Id = 1, Descricao = "Aprender ASP.NET MVC", Concluida = false },
            new Tarefa { Id = 2, Descricao = "Fazer exercícios de C#", Concluida = true }
        };

        // Action que exibe a lista de tarefas
        public ActionResult Index()
        {
            return View(tarefas);
        }

        // Action para adicionar uma nova tarefa
        [HttpPost]
        public ActionResult Adicionar(string descricao)
        {
            if (!string.IsNullOrEmpty(descricao))
            {
                var novaTarefa = new Tarefa
                {
                    Id = tarefas.Count + 1,
                    Descricao = descricao,
                    Concluida = false
                };
                tarefas.Add(novaTarefa);
            }

            return RedirectToAction("Index");
        }

        // Action para marcar uma tarefa como concluída
        public ActionResult Concluir(int id)
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefa.Concluida = true;
            }

            return RedirectToAction("Index");
        }
    }
}
