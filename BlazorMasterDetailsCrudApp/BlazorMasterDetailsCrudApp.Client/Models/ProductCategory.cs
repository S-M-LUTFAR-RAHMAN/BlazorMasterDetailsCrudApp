﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BlazorMasterDetailsCrudApp.Client.Models
{
    //[Table(nameof(ProductCategory))]
    [Table("ProductCategory")]
	public class ProductCategory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  
        public int ProductCategoryID { get; set; }

        [Required, NotNull]
        public string Name { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}