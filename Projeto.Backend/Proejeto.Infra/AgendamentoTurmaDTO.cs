using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Dtos
{
    public class AgendamentoTurmaDTO
    {
        public string Cidade3 { get; set; }
        public int IdAgeTurma { get; set; }
        public string Evento { get; set; }
        public string Region { get; set; }
        public string Sala { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraTermino { get; set; }
        public string Status { get; set; }       
        public int? TotalColaborador { get; set; }
        public int Idade1 { get; set; }
        public int Idade2 { get; set; }

        public void CalcularIdade()
        {
            Idade2 = Idade2;
        }
    }
}
