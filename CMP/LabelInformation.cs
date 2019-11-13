using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CMP
{
    public class LabelInformation
    {
        public string techID { get; set; }
        public string inc { get; set; }
        public string associateID { get; set; }
        public string assocaiteName { get; set; }
        public DateTime date { get; set; }
        public string damage { get; set; }
        public string deviceType { get; set; }
        public string wiped { get; set; }
        public string returnToUser { get; set; }
        
        public  Bitmap QRCode { get; set; }

        


    }
}
