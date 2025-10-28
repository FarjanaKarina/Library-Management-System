<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;
=======
﻿using LMS.ViewModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> 0d323f99f8dcd0d9e554e5f27dd629af1015fa09

namespace LMS.DataModel
{
    public class BookReturn
    {
        [Key]
        public Guid ReturnId { get; set; }
        public Guid IssueId { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal FineAmount { get; set; }
        public string? Remarks { get; set; }
<<<<<<< HEAD
=======
        public object MemberName { get; internal set; }
        public object BookTitle { get; internal set; }
        public object IssueDate { get; internal set; }
        public object Status { get; internal set; }
        public List<BookReturnVM> BookReturnList { get; set; }
>>>>>>> 0d323f99f8dcd0d9e554e5f27dd629af1015fa09
    }
}
