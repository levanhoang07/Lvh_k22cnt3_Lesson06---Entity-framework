using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LvhLesson06CF.Models
{
    public class LvhBook
    {
       
        public int LvhID { get; set; }
        public int LvhBookId { get; set; }
        public string LvhTitle { get; set; }
        public string LvhAuthor { get; set; }
        public int LvhYear { get; set; }
        public string LvhPulisher { get; set; }
        public string LvhPicture { get; set; }
        public int LvhCateghory { get; set; }
        //thuộc tính quan hệ
        public virtual LvhCategory LvhCategory { get; set; }
    }
}