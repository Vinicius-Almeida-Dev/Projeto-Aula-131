using System;
using System.Threading;
using Projeto_Aula_131.Entities;

namespace Projeto_Aula_131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment C1 = new Comment("Comentario UM");
            Comment C2 = new Comment("Comentario DOIS");
            
            Post P1 = new Post(
                DateTime.Parse("31/10/2000 13:30:30"),
                "Titlo",
                "Conteudo",
                12);
            P1.addComment(C1);
            P1.addComment(C2);

            Comment C3 = new Comment("Comentario UM post dois");
            Comment C4 = new Comment("Comentario DOIS post dois");

            Post P2 = new Post(
                DateTime.Parse("27/06/2002 10:00:00"),
                "Titlo DOIS",
                "Conteudo DOIS",
                5);

            P2.addComment(C3);
            P2.addComment(C4);

            Console.WriteLine(P1);
            Console.WriteLine(P2);
        }
    }
}
