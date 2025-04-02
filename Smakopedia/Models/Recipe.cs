using System.Collections.Generic;

namespace Smakopedia.Models
{
    public class Recipe
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
        public List<string> Instructions { get; set; } = new List<string>();
        public int PreparationTime { get; set; }
        public int CookingTime { get; set; }
        public int Servings { get; set; }
        public string Difficulty { get; set; }
        public string Category { get; set; }
        public string ImagePath { get; set; }
    }
} 