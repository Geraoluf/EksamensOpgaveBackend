﻿using System.ComponentModel.DataAnnotations;

namespace EksamensOpgaveBackend.Models
{
    public class ProductModel
    {
            public int Id { get; set; }

            [Required(ErrorMessage = "Du mangler at skrive et produkt navn")]
            public string Name { get; set; }

            public string? Description { get; set; }

            [Required(ErrorMessage = "Pris er påkrævet")]
            [Range(10, 150, ErrorMessage = "Pris skal være mellem 0.01 og 10.000")]
            public double Price { get; set; }

            public string? ImageUrl { get; set; }

            [Range(2015, 2025, ErrorMessage = "Produktionsår skal være over 2015 og under 2025")]
            public int YearOfProduction { get; set; }
       
    }
}
