using System;


namespace Projeto_Aula_131.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        public Comment()
        {
        }
        public Comment(string text)
        {
            Text = text;
        }

    }
}
