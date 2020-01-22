using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Data.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Tag()
        {

        }
        public Tag(string name)
        {
            this.Name = name;
        }
        public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}
