using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.Domain.Entities
{
    public class Store : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }
        public string Schedule { get; set; }
        public string Location { get; set; }
    }
}
