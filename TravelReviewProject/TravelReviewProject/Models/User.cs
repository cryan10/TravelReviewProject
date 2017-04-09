using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace TravelReviewProject.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("City")]
        public string City { get; set; }
        [DisplayName("State")]
        public string State { get; set; }
        [DisplayName("Comments")]
        public string ReviewComment { get; set; }

        [ForeignKey("Hotel")]
        public int HotelID { get; set; }
        [DisplayName("Hotel Location")]
        public virtual Hotel Hotel { get; set; }
    }
}