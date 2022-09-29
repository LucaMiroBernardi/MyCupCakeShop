using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CupcakeEntity.Models
{
    public class CupcakeModel
    {
        // Variable declarations for Cupcakes
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [DisplayName("Date Created")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        [DisplayName("Date Modified")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? DateModified { get; set; }

        // Empty Constructor
        public CupcakeModel()
        {
            Id = -1;
            Name = "";
            Price = 0;
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }

        // Constructor for Cupcake Model
        public CupcakeModel(int id, string name, decimal price, DateTime dateCreated, DateTime? dateModified)
        {
            Id = id;
            Name = name;
            Price = price;
            DateCreated = dateCreated;
            DateModified = dateModified;
        }
    }
}