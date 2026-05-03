using System.ComponentModel.DataAnnotations;

namespace Academico_Dependencia.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O Nome deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "Digite um E-mail válido")]
        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O Telefone é obrigatório")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "O Telefone deve ter entre 10 e 15 caracteres")]
        [RegularExpression(@"^\(?\d{2}\)?[\s-]?\d{4,5}-?\d{4}$", ErrorMessage = "Digite um Telefone válido. Ex: (99)99999-9999")]
        [Display(Name = "Telefone")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "O Endereço é obrigatório")]
        [Display(Name = "Endereco")]
        public string? Endereco { get; set; }

        [Display(Name = "Complemento")]
        public string? Complemento { get; set; }

        [Required(ErrorMessage = "O Bairro é obrigatório")]
        [Display(Name = "Bairro")]
        public string? Bairro { get; set; }

        [Required(ErrorMessage = "O Município é obrigatório")]
        [Display(Name = "Município")]
        public string? Municipio { get; set; }

        [Required(ErrorMessage = "O UF é obrigatório")]
        [Display(Name = "UF")]
        public string? Uf { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório")]
        [StringLength(9, MinimumLength = 8, ErrorMessage = "O CEP deve ter entre 8 e 9 caracteres")]
        [RegularExpression(@"^\d{5}-?\d{3}$", ErrorMessage = "Digite um CEP válido. Ex: 27100-000")]
        [Display(Name = "CEP")]
        public string? Cep { get; set; }

        public Aluno() { }
    }
}