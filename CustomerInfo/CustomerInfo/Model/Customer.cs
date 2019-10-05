using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInfo.Model
{
   public class Customer
    {
        public int Id { set; get; }
        public string Code { get; set; }
        public string Name { set; get; }
        public string Address{ set; get; }
        public string Contact { set; get; }
        public string District { set; get; }
        
    }
}
