﻿namespace GeographicDataAPI.Models
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; } 
        public State State { get; set; } 
        public int Population { get; set; }
    }
}
