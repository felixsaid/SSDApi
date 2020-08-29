using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SSDApp.Models
{
    public class Household
    {
        public int HouseholdId { get; set; }
        public string HeadName { get; set; }
        public bool FuncionalToilet { get; set; }
        public int UsserId { get; set; }

        public virtual User User { get; set; }
    }
}