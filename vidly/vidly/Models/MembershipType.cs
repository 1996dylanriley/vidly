using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class MembershipType
    {
        [Required]
        public string Name { get; set; }
        public byte Id { get; set; }
        public short SignupFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set;}
        public static  readonly int Unknown = 0;
        public static readonly int  PayAsYouGo = 1;

    }
}