using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNosql.Models
{
    public class HAS_INSURANCE
    {
        public DateTime start_date { get; set; }

        public DateTime end_date { get; set; }
        public string status { get; set; }
    }
}
