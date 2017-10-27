using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public DateTime DueDate { get; set; }
        public string Details { get; set; }
        public bool IsDone { get; set; }

        [ForeignKey("List")]
        public int ListID { get; set; }
        //Keeps a reference to whichever list the item is associated with
        public virtual List List { get; set; }
    }
}