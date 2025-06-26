using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Core.Entities
{
    public class Voucher:DomainEntity
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string? Type { get; set; }
        public string? ReferenceNo { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
