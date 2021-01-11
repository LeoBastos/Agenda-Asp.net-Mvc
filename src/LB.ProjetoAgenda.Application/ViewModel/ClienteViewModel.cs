using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace LB.ProjetoAgenda.Application.ViewModel
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            ClienteId = Guid.NewGuid();
            //Agendamentos = new List<AgendamentoViewModel>();
        }

        [Key]
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Nome")]
        [MaxLength(150, ErrorMessage = "Maximo de 150 Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de 3 Caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Email")]
        [MaxLength(100, ErrorMessage = "Maximo de {0} Caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail Válido")]
        [DisplayName("E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF")]
        [MaxLength(11, ErrorMessage = "Máximo {0} Caracteres")]
        [DisplayName("CPF")]
        public string CPF { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataNascimento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }

        //public ICollection<AgendamentoViewModel> Agendamento { get; set; }

    }
}
