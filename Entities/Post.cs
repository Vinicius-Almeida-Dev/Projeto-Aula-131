using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Aula_131.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comment { get; set; } = new List<Comment>();
        public Post()
        {

        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
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

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine(Title);
            SB.Append(Likes);
            SB.Append("Likes - ");
            SB.AppendLine(Moment.ToString("yyyy/MM/dd HH:mm:ss"));
            SB.AppendLine(Content);
            SB.AppendLine("Comments:");
            foreach (Comment obj in Comment)
            {
                SB.AppendLine(obj.Text);
            } 
            return SB.ToString();
        }
    }
}
