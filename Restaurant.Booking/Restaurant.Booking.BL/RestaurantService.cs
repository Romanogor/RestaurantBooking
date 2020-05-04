using Restaurant.Booking.BL.Interfaces;
using Restaurant.Booking.DAL.Entities;
using Restaurant.Booking.DAL.Repositories;
using System;
using System.Collections.Generic;

namespace Restaurant.Booking.BL
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RestaurantService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<DAL.Entities.Restaurant> GetRestaurants()
        {
            return _unitOfWork.RestaurantRepository.GetAll();
        }

        public DAL.Entities.Restaurant GetRestaurant(int id)
        {
            return _unitOfWork.RestaurantRepository.Get(id);
        }

        public DAL.Entities.Restaurant AddRestaurant(DAL.Entities.Restaurant restaurant)
        {
            _unitOfWork.RestaurantRepository.Add(restaurant);
            _unitOfWork.Complete();

            return restaurant;
        }

        public void RemoveRestaurant(DAL.Entities.Restaurant restaurant)
        {
            _unitOfWork.RestaurantRepository.Remove(restaurant);
            _unitOfWork.Complete();
        }

        public Table AddTable(Table table)
        {
            _unitOfWork.TableRepository.Add(table);
            _unitOfWork.Complete();

            return table;
        }

        public void AddTables(List<Table> tables)
        {
            _unitOfWork.TableRepository.AddRange(tables);
            _unitOfWork.Complete();
        }
    }
}
