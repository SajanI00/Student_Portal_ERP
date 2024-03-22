using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity
{
        public class MessageInfo
    {
        [Key]
        public int MessageID { get; set; }
        public string Text { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string AnnouncementType { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
