using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Core.Entities
{
    public interface DomainEntity
    {
        public Guid Id { get; set; }
    }
}
