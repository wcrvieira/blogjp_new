using System.ComponentModel.DataAnnotations;

public class Noticias
{
    public int Id { get; set; }

    public int IdAutor { get; set; }

    [Required(ErrorMessage = "O Título é obrigatório.")]
    [MinLength(3)]
    [MaxLength(100, ErrorMessage = "O Título pode conter, no máximo, 100 caracteres.")]
    public string Titulo { get; set; }    

    [Required(ErrorMessage = "A notícia é obrigatória.")]
    [MinLength(3)]
    public string Noticia { get; set; }

    [Required(ErrorMessage = "Data da notícia é obrigatória.")]
    [Range(typeof(DateTime), "01-01-2023", "31-12-2100")]
    public DateTime Data { get; set; }

    [Required(ErrorMessage = "Senha é obrigatória.")]
    [MinLength(8, ErrorMessage = "A senha deve conter no mínimo 8 caracteres")]
    public string Senha { get; set; }

     public string Status { get; set; }    
}
