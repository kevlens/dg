using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PushBasicData
    {
        public int id { get; set; }
        public string dataop { get; set; }
        public string datatype { get; set; }
        public string datatext { get; set; }
        public int status { get; set; }
        public DateTime? addtime { get; set; }
        public int errnum { get; set; }
    }
}
