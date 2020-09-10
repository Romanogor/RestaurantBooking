using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Booking.BL.Dtos;
using Restaurant.Booking.BL.Interfaces;
namespace Restaurant.Booking.API.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;
        private readonly IMapper _mapper;

        public RestaurantController(IRestaurantService restaurantService, IMapper mapper)
        {
            _restaurantService = restaurantService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RestaurantDto>> GetRestaurants()
        {
            return await _restaurantService.GetRestaurants();
        }

        public async Task<RestaurantDto> GetRestaurant(int id)
        {
            return await _restaurantService.GetRestaurant(id);
        }
    }
}