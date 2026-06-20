using System.ComponentModel.DataAnnotations;

namespace Academico_Dependencia.Models
{
    public class Instituicao
    {
        public int InstituicaoID { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório")]
        [StringLength(150, ErrorMessage = "O Nome deve ter no máximo 150 caracteres")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O Endereço é obrigatório")]
        [StringLength(200, ErrorMessage = "O Endereço deve ter no máximo 200 caracteres")]
        [Display(Name = "Endereço")]
        public string? Endereco { get; set; }

        // Navegação 1:N -> uma Instituição possui vários Departamentos
        public virtual ICollection<Departamento>? Departamentos { get; set; }
    }
}