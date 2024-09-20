namespace Aulaa_11
{
    public class Filme
    {
        public string Titulo { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public int Duracao { get; set; } // Duração em minutos
        public string Sessoes { get; set; } = string.Empty;
        public string ImagemUrl { get; set; } = string.Empty; // URL da imagem do filme
        public string Descricao { get; set; } = string.Empty; // Descrição do filme
    }

}
