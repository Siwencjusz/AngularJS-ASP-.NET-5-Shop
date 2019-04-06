using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Services.Dto;
using SimpleTaskSystem;

namespace Shop.Services.Interfaces
{
    public class GetMiscOutput
    {
        public List<PublisherDto> Publishers { get; set; }
        public List<CoverDto> Covers { get; set; }
        public List<CarrierDto> Carriers { get; set; }
        public List<RelEditionDto> RelEditions { get; set; }

    }
}
