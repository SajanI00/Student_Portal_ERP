using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity
{
    public class Request
    {
        public int RequestID { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverAddress { get; set; }
        public string RegNumber { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
    }
    }
