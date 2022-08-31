using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Dtos
{
    public class AgendamentoColaboradorDto
    {
        public string chapa { get; set; }
        public string Nome { get; set; }
        public int IdAgeColuna { get; set; }
        public string Sobrenome { get; set; }   
        public string Cidade { get; set; }
        public string EstadoCivil { get; set; }

        public void CalcularIdade()
        {

        }
    }    
}
