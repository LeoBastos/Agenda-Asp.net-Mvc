using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace LB.ProjetoAgenda.Application.ViewModel
{
    public class AgendaViewModel
    {
        public AgendaViewModel()
        {
            ClienteId = Guid.NewGuid();
            AgendamentoId = Guid.NewGuid();
            ServicoId = Guid.NewGuid();
        }

        // CLIENTE
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

        //public DomainValidation.Validation.ValidationResul ValidationResult { get; set; }


        // AGENDAMENTO
        [Key]
        public Guid AgendamentoId { get; set; }

        [Required(ErrorMessage = "Agende uma Data")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataAgendamento { get; set; }

        [Required(ErrorMessage = "Agende um Horário")]
        [Display(Name = "Hora Inicial")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: 00:00}")]
        [DataType(DataType.Time, ErrorMessage = "Horario em formato inválido")]
        public DateTime HoraInicial { get; set; }

        [Required(ErrorMessage = "Agende um Horário de Término")]
        [Display(Name = "Hora Final")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: 00:00}")]
        [DataType(DataType.Time, ErrorMessage = "Horario em formato inválido")]
        public DateTime HoraFinal { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "Selecione um Tipo")]
        public string Tipo { get; set; }

        [Display(Name = "Forma de Pagamento")]
        [Required(ErrorMessage = "Selecione uma Forma de Pagamento")]
        public string FormaPagamento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastroAgendamento { get; set; }

       // public DomainValidation.Validation.ValidationResul ValidationResult { get; set; }

        //SERVIÇOS

        [Key]
        public Guid ServicoId { get; set; }

        [Required(ErrorMessage = "Preencha o Serviço")]
        [MaxLength(150, ErrorMessage = "Maximo de 150 Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de 3 Caracteres")]
        public string NomeServico { get; set; }

        //public DomainValidation.Validation.ValidationResul ValidationResult { get; set; }
    }
}
