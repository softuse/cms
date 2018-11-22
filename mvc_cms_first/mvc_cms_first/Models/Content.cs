using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_cms_first.Models
{
    public class Content
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Contents { get; set; }

        public int Status { get; set; }

        public DateTime Add_time { get; set; }

        public DateTime Modify_time { get; set; }
    }
}
