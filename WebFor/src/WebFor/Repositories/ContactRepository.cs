﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFor.Models;

namespace WebFor.Repositories
{
    public class ContactRepository:IContactRepository
    {
        private ApplicationDbContext _context;

        public ContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Contact FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetAll(Func<Contact, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}