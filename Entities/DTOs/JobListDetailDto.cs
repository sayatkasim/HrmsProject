using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class JobListDetailDto : IDto
    {
        public int JobListId { get; set; }
        public string JobListName { get; set; }
    }
}
