using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class GaleriaModel : PageModel
{
    public List<Imagem> Imagens { get; set; }

    public void OnGet()
    {
        // Simulação de uma galeria de imagens
        Imagens = new List<Imagem>
        {
            new Imagem { Url = "/images/img1.jpg", Descricao = "Imagem 1" },
            new Imagem { Url = "/images/img2.jpg", Descricao = "Imagem 2" },
            new Imagem { Url = "/images/img3.jpg", Descricao = "Imagem 3" }
        };
    }
}

public class Imagem
{
    public string Url { get; set; }
    public string Descricao { get; set; }
}
