using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academico_Dependencia.Models
{
    public class Departamento
    {
        public int DepartamentoID { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório")]
        [StringLength(150, ErrorMessage = "O Nome deve ter no máximo 150 caracteres")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A Instituição é obrigatória")]
        [Display(Name = "Instituição")]
        public int InstituicaoID { get; set; }

        // Navegação N:1 -> um Departamento pertence a uma Instituição
        [ForeignKey("InstituicaoID")]
        public virtual Instituicao? Instituicao { get; set; }
    }
}