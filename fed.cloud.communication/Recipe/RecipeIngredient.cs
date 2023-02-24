using System;

namespace fed.cloud.communication.Recipe
{
    public class RecipeIngredient
    {
        public Guid Id { get; set; }
        
        public string IngredientName { get; set; }
        
        public int ReferenceNumber { get; set; }
        
        public double Quantity { get; set; }
        
        public int Unit { get; set; }
    }
}