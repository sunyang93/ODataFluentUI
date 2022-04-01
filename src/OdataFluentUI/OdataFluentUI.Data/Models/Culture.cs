﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OdataFluentUI.Data.Models
{
    /// <summary>
    /// Lookup table containing the languages in which some AdventureWorks data is stored.
    /// </summary>
    [Table("Culture", Schema = "Production")]
    [Index(nameof(Name), Name = "AK_Culture_Name", IsUnique = true)]
    public partial class Culture
    {
        public Culture()
        {
            ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
        }

        /// <summary>
        /// Primary key for Culture records.
        /// </summary>
        [Key]
        [StringLength(6)]
        public string CultureID { get; set; }
        /// <summary>
        /// Culture description.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty(nameof(ProductModelProductDescriptionCulture.Culture))]
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
    }
}