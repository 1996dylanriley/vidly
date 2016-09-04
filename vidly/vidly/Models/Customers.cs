using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace vidly.Models
{
    public class Customers
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { set; get; }
        public MembershipType MembershipType { get; set; }
        [Display(Name= "Membership Type")]
        public byte MembershipTypeId { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}