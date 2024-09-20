using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Aulaa_11;

namespace Aula_11.Pages
{
    public class FilmesModel : PageModel
    {
        public List<Filme> Filmes { get; set; } = new List<Filme>();

        public void OnGet()
        {
            Filmes = new List<Filme>
        {
            new Filme
            {
                    Titulo = "DeadPool & Wolverine",
                    Genero = "Ação/Comédia",
                    Duracao = 127,
                    Sessoes = "14:00, 18:00",
                    ImagemUrl = "/images/deadpool_wolverine.jpg"
                },
                new Filme
                {
                    Titulo = "Divertida Mente 2",
                    Genero = "Infantil/Comédia",
                    Duracao = 96,
                    Sessoes = "16:00, 20:00",
                    ImagemUrl = "/images/divertida_mente_2.webp"
                },
                new Filme
                {
                    Titulo = "Meu Malvado Favorito 4",
                    Genero = "Infantil/Comédia",
                    Duracao = 94,
                    Sessoes = "15:00, 19:00",
                    ImagemUrl = "/images/meu_malvado_favorito_4.jfif"
                },
                new Filme
                {
                    Titulo = "O Corvo",
                    Genero = "Ação/Fantasia",
                    Duracao = 102,
                    Sessoes = "17:00, 21:00",
                    ImagemUrl = "/images/o_corvo.jfif"
                },
                new Filme
                {
                    Titulo = "HellBoy e o Homem Torto",
                    Genero = "Terror/Ação",
                    Duracao = 115,
                    Sessoes = "13:00, 17:00",
                    ImagemUrl = "/images/hellboy_homem_torto.jpg"
                },
                new Filme
                {
                    Titulo = "Luccas e Gi em Dinossauros",
                    Genero = "Infantil/Aventura",
                    Duracao = 91,
                    Sessoes = "13:00, 17:00",
                    ImagemUrl = "/images/luccas_gi_dinossauros.jpg"
                },


            };
        }
    }
}
