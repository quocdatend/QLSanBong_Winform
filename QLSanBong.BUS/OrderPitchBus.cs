﻿using Microsoft.EntityFrameworkCore;
using QLSanBong.DAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.BUS
{
    public class OrderPitchBus
    {
        private QlsanBongDaMiniContext _context = new QlsanBongDaMiniContext();
        public OrderPitchBus() { }
        
        // get all
        public List<OrderPitch> GetAll()
        {
            return _context.OrderPitches.ToList();
        }

        // add
        public void Add(OrderPitch orderPitch)
        {
            _context.OrderPitches.Add(orderPitch);
            _context.SaveChanges();
        }

        // delete
        public void Delete(OrderPitch orderPitch)
        {
            _context.OrderPitches.Remove(orderPitch);
            _context.SaveChanges();
        }

        // get by user id
        public List<OrderPitch> GetByUserId(int id)
        {
            List<OrderPitch> orderPitches = _context.OrderPitches.Where(x=>x.UserId == id).ToList();
            return orderPitches;
        }

        // get by daytime start, end
        public List<OrderPitch> GetByDateTime(DateTime start, DateTime end)
        {
            List<OrderPitch> orderPitches = _context.OrderPitches.Where(x=>x.TimeStart == start && x.TimeEnd == end).ToList();
            return orderPitches;
        }

        // get by day
        public List<OrderPitch> GetByDay(DateTime day)
        {
            List<OrderPitch> orderPitches = _context.OrderPitches.ToList();
            List<OrderPitch> getOrderPitchs = orderPitches.Where(x=>DateTime.ParseExact(x.TimeStart.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null) == day).ToList(); 
            return getOrderPitchs;
        }

        // get by id
        public List<OrderPitch> GetById(int id)
        {
            List<OrderPitch> orderPitches = _context.OrderPitches.Where(x => x.Id == id).ToList();
            return orderPitches;
        }

        // chage status check
        public void ChangeCheck(OrderPitch orderPitch)
        {
            _context.Entry(orderPitch).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // chage status Cancel
        public void ChangeCancel(OrderPitch orderPitch)
        {
            _context.Entry(orderPitch).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
