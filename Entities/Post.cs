using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Aula_131.Entities
{
    internal class Post
    {
        public DateTime Monmet { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comment { get; set; } = new List<Comment>();
        public Post()
        {

        }
        public Post(DateTime monmet, string title, string content, int likes)
        {
            Monmet = monmet;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void addComment(Comment comment)
        {
            Comment.Add(comment);
        }
        public void removeComment(Comment comment)
        {
            Comment.Remove(comment);
        }
    }
}
