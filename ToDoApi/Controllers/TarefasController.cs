using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoApi.Models;


namespace ToDoApi.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class TarefasController : ControllerBase
        {
            private static List<Tarefa> Tarefas = new List<Tarefa>();

            // GET: api/tarefas
            [HttpGet]
            public IActionResult GetTarefas()
            {
                return Ok(Tarefas);
            }

            // POST: api/tarefas
            [HttpPost]
            public IActionResult AdicionarTarefa([FromBody] Tarefa tarefa)
            {
                tarefa.Id = Tarefas.Count + 1;
                Tarefas.Add(tarefa);
                return Ok(tarefa);
            }

            // PUT: api/tarefas/{id}
            [HttpPut("{id}")]
            public IActionResult AtualizarTarefa(int id, [FromBody] Tarefa tarefaAtualizada)
            {
                var tarefa = Tarefas.Find(t => t.Id == id);
                if (tarefa == null)
                {
                    return NotFound();
                }

                tarefa.Titulo = tarefaAtualizada.Titulo;
                tarefa.Concluida = tarefaAtualizada.Concluida;
                return Ok(tarefa);
            }

            // DELETE: api/tarefas/{id}
            [HttpDelete("{id}")]
            public IActionResult ExcluirTarefa(int id)
            {
                var tarefa = Tarefas.Find(t => t.Id == id);
                if (tarefa == null)
                {
                    return NotFound();
                }

                Tarefas.Remove(tarefa);
                return Ok();
            }
        }
    }

