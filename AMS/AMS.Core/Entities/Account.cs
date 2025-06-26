using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Core.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserType { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Recieveable { get; set; }
        public Guid? ParentAccountId { get; set; }
    }
}
