using Restaurant.Booking.DAL.Entities;
using Restaurant.Booking.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Booking.BL
{
    public class OrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddOrder(Order order)
        {
            _unitOfWork.OrderRepository.Add(order);
            _unitOfWork.Complete();
        }

        public void RemoveOrder(Order order)
        {
            _unitOfWork.OrderRepository.Remove(order);
            _unitOfWork.Complete();
        }

        public void CancelOrder(Order order, OrderStatus orderStatus)
        {
            _unitOfWork.OrderRepository.ChangeOrderStatus(order, orderStatus);
            _unitOfWork.Complete();
        }

    }
}
