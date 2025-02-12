using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notas
{
    public class Gerenciador
    {
        private List<Nota> notas = new List<Nota>();

        public void Adicionar(string descricao){
            var nota = new Nota{Descricao = descricao};

            notas.Add(nota);
        }
        public void Exibirtodas()
        {
            foreach( var nota in notas)
            {
                nota.Exibir();
            }
        }
    }
}