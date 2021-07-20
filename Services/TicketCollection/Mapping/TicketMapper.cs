using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketCollection.Dtos;
using TicketCollection.Models;

namespace TicketCollection.Mapping
{
    public class TicketMapper : Profile
    {
        //Maps tickets
        public TicketMapper()
        {
            CreateMap<Ticket, TicketDto>()
                .ForMember(dest => dest.CategoryName, opts => opts.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.StatusName, opts => opts.MapFrom(src => src.Status.Name))
                .ForMember(dest => dest.PriorityName, opts => opts.MapFrom(src => src.Priority.Name));

        }
    }
}
