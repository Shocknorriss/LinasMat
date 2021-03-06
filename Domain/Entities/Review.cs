﻿namespace Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public Score Score { get; set; }
        public string Description { get; set; }
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

    }

    public enum Score
    {
        Bad,
        Decent,
        Good,
        Excellent,
        Outstanding
    }
}