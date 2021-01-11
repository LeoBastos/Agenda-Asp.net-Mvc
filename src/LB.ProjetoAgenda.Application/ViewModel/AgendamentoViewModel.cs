using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace LB.ProjetoAgenda.Application.ViewModel
{
    public class AgendamentoViewModel
    {
        public AgendamentoViewModel()
        {
            AgendamentoId = Guid.NewGuid();
            Clientes = new List<ClienteViewModel>();
            Servicos = new List<ServicoViewModel>();
        }

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

        public ICollection<ClienteViewModel> Clientes { get; set; }
        public ICollection<ServicoViewModel> Servicos { get; set; }


    }
}

