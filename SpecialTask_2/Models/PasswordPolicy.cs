
using System;
using System.Collections.Generic;
using System.Linq; using
System.Web;
namespace SpecialTask_2.Models
{
    public class
PasswordPolicy
    {
        public int minLength { get; set; }
        public int lowercase { get; set; }
        public int uppercase { get; set; }
        public int numeric { get; set; }
        public int special_char { get; set; }
    }
}
