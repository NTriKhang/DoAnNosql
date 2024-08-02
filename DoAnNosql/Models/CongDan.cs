using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNosql.Models
{
    public class CongDan
    {
        public string id { get; set; }
        public string hoTen { get; set; }
        public int tuoi { set; get; }
        public string cccd { set; get; } = string.Empty;

        public DateTime ngaysinh { set; get; }
        public string diachi { set; get; }



    }
}
