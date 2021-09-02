using System;
using Exercicio_StringBuilder.Entities;
using System.Collections.Generic;
using System.Text;
namespace Exercicio_StringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {

        }
        public Post(DateTime momet, string title, string content, int likes)
        {
            Moment = momet;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);

        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);

        }

        public override string ToString()
        {
            // usar stringBuilder quando a string a grande(melhor performance)
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append("likes -");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.Append("Comments");
            // percorrer os comentários
            foreach (Comment c in Comments)
            {
                sb.Append(c.Text);

            }
            return sb.ToString();




            //return $"{Title} " +
            //    $"{Likes} likes - {Moment}" +
            //    $"{Content} " +
            //    $"Comments:" +
            //    $"{Comments}";

        }
    }
}
