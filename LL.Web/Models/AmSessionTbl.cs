using System;
using System.Collections.Generic;

namespace LL.Web.Models
{
    public partial class AmSessionTbl
    {
        public int UserId { get; set; }
        public int LastActive { get; set; }
        public int Sessions { get; set; }
        public int SessionDuration { get; set; }
        public int Clicks { get; set; }
        public int MailOffender { get; set; }
        public int NotSpammed { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte[] ModifiedDate { get; set; }
    }
}
