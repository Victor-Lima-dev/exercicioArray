using System;

namespace Estudos
{
    class Estudante
    {
         public string Nome {set; get;}
         public string Email {set; get;}

         public Estudante (string nome, string email)
         {
            Nome = nome;
            Email = email;
         }

    }
}