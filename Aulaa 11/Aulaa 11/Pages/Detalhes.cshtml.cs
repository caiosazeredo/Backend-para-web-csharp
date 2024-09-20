using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Aulaa_11;

namespace Aula_11.Pages
{
    public class DetalhesModel : PageModel
    {
        public Filme Filme { get; set; } = new Filme();

        public void OnGet(int id)
        {
            // Simulação de um banco de dados ou repositório
            var filmes = new List<Filme> 
            {
                new Filme
                {
                    Titulo = "DeadPool & Wolverine",
                    Genero = "Ação/Comédia",
                    Duracao = 127,
                    Sessoes = "14:00, 18:00",
                    ImagemUrl = "/images/deadpool_wolverine.jpg",
                    Descricao = "Deadpool e Wolverine se unem em uma missão inusitada que mistura ação e comédia, trazendo muita adrenalina e humor negro. Eles precisam enfrentar uma ameaça que desafia suas habilidades enquanto lidam com suas próprias diferenças."
                },
                new Filme
                {
                    Titulo = "Divertida Mente 2",
                    Genero = "Infantil/Comédia",
                    Duracao = 96,
                    Sessoes = "16:00, 20:00",
                    ImagemUrl = "/images/divertida_mente_2.webp",
                    Descricao = "Riley está crescendo, e com isso, novas emoções surgem em sua mente. Alegria, Tristeza, Raiva, Medo e Nojinho voltam para novas aventuras enquanto tentam ajudar Riley a navegar pelas complexidades da adolescência."
                },
                new Filme
                {
                    Titulo = "Meu Malvado Favorito 4",
                    Genero = "Infantil/Comédia",
                    Duracao = 94,
                    Sessoes = "15:00, 19:00",
                    ImagemUrl = "/images/meu_malvado_favorito_4.jfif",
                    Descricao = "Gru e seus Minions estão de volta para mais uma aventura hilária. Desta vez, Gru enfrenta um vilão ainda mais perverso enquanto tenta equilibrar sua vida de supervilão aposentado com sua família sempre em expansão."
                },
                new Filme
                {
                    Titulo = "O Corvo",
                    Genero = "Ação/Fantasia",
                    Duracao = 102,
                    Sessoes = "17:00, 21:00",
                    ImagemUrl = "/images/o_corvo.jfif",
                    Descricao = "Um homem misterioso retorna do além-túmulo para vingar sua própria morte e a morte de sua noiva. Guiado por um corvo, ele caça os responsáveis e descobre que a vingança pode ser tão dolorosa quanto redentora."
                },
                new Filme
                {
                    Titulo = "HellBoy e o Homem Torto",
                    Genero = "Terror/Ação",
                    Duracao = 115,
                    Sessoes = "13:00, 17:00",
                    ImagemUrl = "/images/hellboy_homem_torto.jpg",
                    Descricao = "Hellboy enfrenta seu mais novo inimigo, o sinistro Homem Torto, em uma batalha que mistura horror e ação. Enquanto luta para salvar a humanidade, Hellboy deve também enfrentar seus próprios demônios internos."
                },
                new Filme
                {
                    Titulo = "Luccas e Gi em Dinossauros",
                    Genero = "Infantil/Aventura",
                    Duracao = 91,
                    Sessoes = "13:00, 17:00",
                    ImagemUrl = "/images/luccas_gi_dinossauros.jpg",
                    Descricao = "Luccas e Gi embarcam em uma aventura pré-histórica ao serem transportados para um mundo cheio de dinossauros. Com coragem e inteligência, eles precisam encontrar uma maneira de voltar para casa antes que seja tarde demais."
                }
            };

            // Encontra o filme pelo ID (posição na lista, por exemplo)
            Filme = filmes.ElementAtOrDefault(id - 1);  // ID 1 será o primeiro filme, ID 2 será o segundo, etc.
        }
    }
}
