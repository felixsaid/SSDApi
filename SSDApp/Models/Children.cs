using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSDApp.Models
{
    public class Children
    {
        public int ChildrenId { get; set; }
        public int ChildrenNumber { get; set; }
        public int UsserId { get; set; }

        public virtual User User { get; set; }
    }
}