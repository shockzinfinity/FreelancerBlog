﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFor.Models;

namespace WebFor.Repositories
{
    public class SiteOrderRepository:ISiteOrderRepository
    {
        private ApplicationDbContext _context;

        public SiteOrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(SiteOrder entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(SiteOrder entity)
        {
            throw new NotImplementedException();
        }

        public SiteOrder FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SiteOrder> GetAll(Func<SiteOrder, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}