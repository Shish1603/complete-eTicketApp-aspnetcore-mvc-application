﻿using eTicketApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketApp.Data.Services
{
    public class ActorsService : IActorsService
    {
        //Inject AppDbContext
        private readonly ApplicationDbContext _context;
        public ActorsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
