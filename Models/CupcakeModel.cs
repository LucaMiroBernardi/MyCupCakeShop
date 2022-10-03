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
        //[MaxLength(14, ErrorMessage = "Max 14 Characters")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Invalid name.")]
        public string Name { get; set; }
        [Required]
        [Range(0.01, 100.00, ErrorMessage = "Price must be between $0.01 and $100.00")]
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