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

        public RestaurantService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<DAL.Entities.Restaurant>> GetRestaurants()
        {
            return await _unitOfWork.RestaurantRepository.GetAll();
        }

        public async Task<DAL.Entities.Restaurant> GetRestaurant(int id)
        {
            return await Task.Run(() =>_unitOfWork.RestaurantRepository.Get(id));
        }

        public DAL.Entities.Restaurant AddRestaurant(DAL.Entities.Restaurant restaurant)
        {
            _unitOfWork.RestaurantRepository.Add(restaurant);
            _unitOfWork.Complete();

            return restaurant;
        }

        public async Task RemoveRestaurant(DAL.Entities.Restaurant restaurant)
        {
            _unitOfWork.RestaurantRepository.Remove(restaurant);
            await _unitOfWork.Complete();
        }

        public async Task<Table> AddTable(Table table)
        {
            _unitOfWork.TableRepository.Add(table);
            await _unitOfWork.Complete();

            return table;
        }

        public async Task AddTables(List<Table> tables)
        {
            _unitOfWork.TableRepository.AddRange(tables);
            await _unitOfWork.Complete();
        }
    }
}
