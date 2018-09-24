using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauChoice.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public DateTime DateComment { get; set; }
        public string Commentaire { get; set; }
        public virtual TheUser TheUser { get; set; }
        public virtual Evenement Evenement { get; set; }

        public Comment()
        {
        }

        public Comment(DateTime dateComment, string commentaire)
        {
            DateComment = dateComment;
            Commentaire = commentaire;
        }
    }
}