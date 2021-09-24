using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class EntrarSalaModel : ComunicacaoModel
    {
        public EntrarSalaModel(string acao, string sala)
        {
            Acao = acao;
            Sala = sala;
        }
        public string Sala { get; set; }
    }
}
