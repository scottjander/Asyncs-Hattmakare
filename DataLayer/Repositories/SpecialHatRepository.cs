﻿using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class SpecialHatRepository
    {
        private readonly HatDbContext _context;
        public SpecialHatRepository()
        {
            _context = new HatDbContext();
        }

        public void addSpecialHat(SpecialHat hat, int id)
        {
            var currentOrder = _context.Orders.FirstOrDefault(o => o.Id == id); //går att förbättra 
            currentOrder.Hats.Add(hat);
            _context.SaveChanges();
        }
    }
}
