using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Booking.DAL.Entities;
using Restaurant.Booking.BL.Dtos;

namespace Restaurant.Booking.BL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DAL.Entities.Restaurant, RestaurantDto>();
            CreateMap<RestaurantDto, DAL.Entities.Restaurant>();
        }
    }
}
