using AutoMapper;
using Restaurant.Booking.BL.Dtos;
using Restaurant.Booking.BL.Interfaces;
using Restaurant.Booking.DAL.Entities;
using Restaurant.Booking.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.Booking.BL
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RestaurantService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RestaurantDto>> GetRestaurants()
        {
            var restaurants = await _unitOfWork.RestaurantRepository.GetAll();
            List<RestaurantDto> restaurantDtos = new List<RestaurantDto>();
            foreach (var restaurant in restaurants)
            {
                RestaurantDto restaurantDto = _mapper.Map<RestaurantDto>(restaurant);
                restaurantDtos.Add(restaurantDto);
            }

            return restaurantDtos;
        }

        public async Task<RestaurantDto> GetRestaurant(int id)
        {
            var restaurant = await _unitOfWork.RestaurantRepository.Get(id);

            RestaurantDto restaurantDto = _mapper.Map<RestaurantDto>(restaurant);

            return restaurantDto;

        }

        public RestaurantDto AddRestaurant(RestaurantDto restaurantDto)
        {
            DAL.Entities.Restaurant restaurant = _mapper.Map<DAL.Entities.Restaurant>(restaurantDto);
            _unitOfWork.RestaurantRepository.Add(restaurant);
            _unitOfWork.Complete();

            return restaurantDto;
        }

        public async Task RemoveRestaurant(RestaurantDto restaurantDto)
        {
            DAL.Entities.Restaurant restaurant = _mapper.Map<DAL.Entities.Restaurant>(restaurantDto);
            _unitOfWork.RestaurantRepository.Remove(restaurant);
            await _unitOfWork.Complete();
        }

        public async Task<TableDto> AddTable(TableDto tableDto)
        {
            Table table = _mapper.Map<Table>(tableDto);
            _unitOfWork.TableRepository.Add(table);
            await _unitOfWork.Complete();

            return tableDto;
        }

        public async Task AddTables(List<TableDto> tableDtos)
        {
            List<Table> tables = new List<Table>();
            foreach (var tableDto in tableDtos)
            {
                Table table = _mapper.Map<Table>(tableDto);
                tables.Add(table);
            }

            _unitOfWork.TableRepository.AddRange(tables);
            await _unitOfWork.Complete();
        }
    }
}
