﻿namespace PokemonReview.API.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Owner> Owner { get; set; }
    }
}
