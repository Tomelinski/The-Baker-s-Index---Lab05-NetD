using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab05.Models
{
    public class Recipe
    {
        //constructors
        public int recipeId { get; set; }

        //foriegn key, not sure if its connected properly though
        [ForeignKey("id")]
        public string Author { get; set; }

        public string recipeName { get; set; }

        public string type { get; set; }

        public string ingredients { get; set; }

        public string cookTime { get; set; }

        public string directions { get; set; }

    }
}
