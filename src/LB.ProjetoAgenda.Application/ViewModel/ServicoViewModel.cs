using System;
using System.ComponentModel.DataAnnotations;


namespace LB.ProjetoAgenda.Application.ViewModel
{
    public class ServicoViewModel
    {
        public ServicoViewModel()
        {
            ServicoId = Guid.NewGuid();
            //Agendamentos = new List<AgendamentoViewModel>();
        }

        [Key]
        public Guid ServicoId { get; set; }

        [Required(ErrorMessage = "Preencha o Serviço")]
        [MaxLength(150, ErrorMessage = "Maximo de 150 Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de 3 Caracteres")]
        public string NomeServico { get; set; }
    }
}
