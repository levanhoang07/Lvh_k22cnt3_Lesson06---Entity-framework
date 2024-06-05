using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LvhLesson06CF.Models
{
    public class LvhBook
    {
       [Key]
        public int LvhID { get; set; }
        public string  LvhBookId { get; set; }
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