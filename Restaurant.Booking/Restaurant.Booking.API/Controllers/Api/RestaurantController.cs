using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Booking.BL.Interfaces;
using Restaurant.Booking.DAL.Repositories;

namespace Restaurant.Booking.API.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        public IEnumerable<DAL.Entities.Restaurant> GetRestaurants()
        {
            return _restaurantService.GetRestaurants();
        }
    }
}