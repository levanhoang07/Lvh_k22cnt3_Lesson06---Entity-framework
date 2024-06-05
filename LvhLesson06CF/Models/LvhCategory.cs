using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LvhLesson06CF.Models
{
    public class LvhCategory
    {
        public int  LvhID { get; set; }
        public string LvhCategoryName { get; set; }
        // thuộc tính quan hệ
        public virtual ICollection<LvhBook> LvhBooks { get; set; }
    }
    
}