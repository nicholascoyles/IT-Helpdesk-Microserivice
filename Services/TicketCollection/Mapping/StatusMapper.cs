using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketCollection.Dtos;
using TicketCollection.Models;

namespace TicketCollection.Mapping
{
    //Maps Status
    public class StatusMapper : Profile
    {
        public StatusMapper()
        {
            CreateMap<Status, StatusDto>().ReverseMap();
        }
    }
}