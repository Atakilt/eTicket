using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eticket.Models;

namespace eticket.Data.Services
{
    public interface IActorsService
    {
        IEnumerable<Actor> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}