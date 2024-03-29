﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        [Required]
        public string Name { get; set; }

        [Display(Name="Type of food")]
        public CuisineType Cuisine { get; set; }
    }
}
