using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notas
{
    public class Nota
    {
        public string Descricao { get; set; }

        public void Exibir(){
            Console.WriteLine(Descricao);
            Console.WriteLine("--------------------");


        }

    }
}