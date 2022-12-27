using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetExercicios.Models
{
    public class QuemSou
    {
        public string meuNome = "Renan";
        public int minhaIdade = 24;

        public void Apresentacao()
        {
            Console.WriteLine($"Olá, meu nome é {meuNome}, e eu tenho {minhaIdade} anos");
        }

    }
}