using System.ComponentModel.DataAnnotations;

namespace ClientesApp.API.Dtos
{
    public class ClienteRequestDto
    {
        #region Propriedades
        [MinLength (8 , ErrorMessage = "Favor informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Favor informa no máximo {1} caracteres.")]
        [Required(ErrorMessage ="Favor informe o nome do cliente.")]
        public string Nome { get; set; }
        [EmailAddress(ErrorMessage = "Favor informe um endereço de email valido.")]
        [Required(ErrorMessage = "Favor informe o email do cliente.")]
        public string Email {  get; set; }
        [Required(ErrorMessage = "Favor informe o CPF do cliente.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Favor informe o CPF com apenas 11 numeros.")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Favor, informe a categoria do cliente.")]
        [Range(1, 4, ErrorMessage = "A categoria só deve aceitar valores 1, 2, 3 ou 4.")]
        public int Categoria { get; set; }

        #endregion
    }

}
