using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facebook_Web.Models
{
    public class PostEntity
    {
        public string ImageB64 { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public string Reactions { get; set; }
        public PostEntity(string imageB64, string name, string date, string description, string comments, string reactions)
        {
            ImageB64 = imageB64;
            Name = name;
            Date = date;
            Description = description;
            Comments = comments;
            Reactions = reactions;
        }
    }
}
