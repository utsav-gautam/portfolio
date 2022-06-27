using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtitecturePortfolioApp.Models
{
    public class EnquiryMetaData
    {
        [StringLength(20)]
        [Required]
        public string Name { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        [StringLength(100)]
        [Required]
        public string Query { get; set; }

    }
    [MetadataType(typeof(EnquiryMetaData))]
    public partial class Enquiry { }
}