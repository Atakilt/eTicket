using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eticket.Data;
using eticket.Models;
using Microsoft.EntityFrameworkCore;

namespace eticket.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context=context;
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            return await _context.Actors.ToListAsync();
        }

        public Actor GetById(int id)
        {
            return _context.Actors.Find(id);
        } 

        public void Add(Actor actor)
        {
            _context.Add(actor);
            _context.SaveChanges();
        }

        public Actor Update(int id, Actor newActor)
        {
            var oldActor = _context.Actors.Find(id);

            if(oldActor!=null)
            {
                _context.Actors.Update(newActor);
            }

            return newActor;
        }

        public void Delete(int id)
        {
            var actor = _context.Actors.Find(id);

            if(actor!=null)
            {
                _context.Remove(actor);
            }
        }
    }
}