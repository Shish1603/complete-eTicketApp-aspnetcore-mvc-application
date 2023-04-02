using eTicketApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketApp.Data.Services
{
    public interface IActorsService
    {
        //get all actors->Ienum
        Task <IEnumerable<Actor>> GetAll();

        //return single actor
        Actor GetById(int id);

        //Adding an actor
        void Add(Actor actor);
        
        //Update actor
        Actor Update(int id, Actor newActor);

        //Delete Actor
        void Delete(int id);
    }
}
