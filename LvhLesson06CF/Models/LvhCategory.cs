using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace LvhLesson06CF.Models
{
    public class LvhCategory
    {
        [Key]
        public int  LvhID { get; set; }
        public string LvhCategoryName { get; set; }
        // thuộc tính quan hệ
        public virtual ICollection<LvhBook> LvhBooks { get; set; }
    }

}


