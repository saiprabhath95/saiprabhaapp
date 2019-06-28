using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LL.Web.ViewModel
{
    public class WebSessionItem
    {
        [Range(0, 50)]
        public int lastActive { get; set; }

        [Range(0, 50)]
        public int sessions { get; set; }

        [Range(0, 50)]
        public int sessionDuration { get; set; }

        [Range(0, 2500)]
        public int clicks { get; set; }

        [Range(0, 50)]
        public int mailOffender { get; set; }

        [Range(0, 50)]
        public int notSpammed { get; set; }
    }
}
