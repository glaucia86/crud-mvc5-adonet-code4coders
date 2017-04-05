using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class Funcionario
    {
        [Display(Name = "Id do Funcionário")]
        public int IdFuncionario { get; set; }

        [Required(ErrorMessage = "Campo 'Nome' é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo 'Sobrenome' é obrigatório")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Campo 'Cidade' obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo 'Endereço' é obrigatório")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo 'E-mail' é obrigatório")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

    }
}