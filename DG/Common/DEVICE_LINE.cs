using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DG.Common
{
    public class DEVICE_LINE
    {
        public BROKENRAIL_BDATA_DEVICE device { get; set; }
        public BROKENRAIL_SECTION_LINE line { get; set; }
        public string POINT_NO { get; set; }
    }
}
