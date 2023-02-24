using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fed.cloud.communication.Recipe
{
    public class Recipe
    {
        public Guid Id { get; set; }
        
        public string RecipeName { get; set; }

        public TimeSpan CookingTime { get; set; }

        public IEnumerable<string> Tags { get; set; }

        public IEnumerable<string> Contents { get; set; }
        
        public IEnumerable<RecipeIngredient> Ingredients { get; set; }

        public string PackContent()
        {
            var formated = Contents.Select(x => new StringBuilder().Append("{{").Append(x).Append("}}").ToString());
            return string.Join(";", formated);
        }
    }
}