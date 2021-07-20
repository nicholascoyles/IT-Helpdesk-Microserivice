using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketCollection.Dtos;
using TicketCollection.Models;
namespace TicketCollection.Mapping
{
    //Maps Priority
    public class PriorityMapper : Profile
    {
        public PriorityMapper()
        {
            CreateMap<Priority, PriorityDto>().ReverseMap();
        }
    }
}