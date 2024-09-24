using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.Application.Dtos
{
    public class StoreDtoGetAll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }
        public string Schedule { get; set; }
        public string Location { get; set; }
        public DateTime CreatedAt { get; set; }

    }

    public class StoreDtoGetSingle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }
        public string Schedule { get; set; }
        public string Location { get; set; }
    }
}
