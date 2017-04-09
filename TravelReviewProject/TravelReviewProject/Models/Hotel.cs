using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace TravelReviewProject.Models
{
    public class Hotel
    {
        [Key]
        [DisplayName("Hotel Location")]
        public int HotelID { get; set; }      
        public string HotelLocation { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}