using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Escola.Pages
{
    public class DiferenciaisModel : PageModel
    {
        public List<Professor> x { get; set; } = new List<Professor>();
        public void OnGet()
        {
            x = new List<Professor>
    {
        new Professor
{
    Descricao = @"Alvaro Cunha
Especialista em Seguran�a Cibern�tica e Prote��o de Dados",
    ImagemUrl = "Imagens/beard.jpg"
},
new Professor
{
    Descricao = @"Willy Bronca
Especialista em Intelig�ncia Artificial e Machine Learning",
    ImagemUrl = "Imagens/cigar.jpg"
},
new Professor
{
    Descricao = @"Leoncio Junior
Desenvolvedor de Software e Arquitetura de Sistemas",
    ImagemUrl = "Imagens/human.jpg"
},
new Professor
{
    Descricao = @"Olivia Cabelo
Consultora em Infraestrutura de TI e Redes",
    ImagemUrl = "Imagens/girl.jpg"
},
new Professor
{
    Descricao = @"Elviz Pretzel
Engenheiro de Dados e An�lise de Big Data",
    ImagemUrl = "Imagens/fashion.jpg"
},
new Professor
{
    Descricao = @"Zeca Oliveira
Especialista em Desenvolvimento de Aplica��es M�veis",
    ImagemUrl = "Imagens/man.jpg"
},
new Professor
{
    Descricao = @"Maria Ana Ramalho
Analista de Sistemas e Gerenciamento de Projetos de TI",
    ImagemUrl = "Imagens/woman.jpg"
},
new Professor
{
    Descricao = @"Am�lia Ramos
Especialista em Usabilidade e Design de Interfaces",
    ImagemUrl = "Imagens/womam.jpg"
},
new Professor
{
    Descricao = @"Oscar Jos�
Consultor em Transforma��o Digital e Inova��o Tecnol�gica",

    ImagemUrl = "Imagens/Prof.png"
}



        };
        }
    }
}
