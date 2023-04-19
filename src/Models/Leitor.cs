using System.ComponentModel.DataAnnotations;

public class Leitor
{
    public int Id { get; set; }

    [Required(ErrorMessage = "E-mail é obrigatório")]
    [MinLength(3)]
    [MaxLength(100, ErrorMessage = "O e-mail pode conter, no máximo, 10 caracteres")]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    public string Email { get; set; }

    [Required(ErrorMessage = "Nome é obrigatório")]
    [MinLength(3)]
    [MaxLength(30, ErrorMessage = "O nome pode conter, no máximo, 30 caracteres")]
    public string Nome { get; set; }
    
    [Required]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A Data de nascimento é obrigatória")]
    [Range]
    public date Nascimento { get; set; }
    
    [Required]
    public date Nascimento { get; set; }

    [Required(ErrorMessage = "Senha é obrigatório")]
    [MinLength(3)]
    [MaxLength(20, ErrorMessage = "A senha pode conter, no máximo, 20 caracteres")]
    public string Senha { get; set; }
    
    [Required]
    public string Senha { get; set; }    
}