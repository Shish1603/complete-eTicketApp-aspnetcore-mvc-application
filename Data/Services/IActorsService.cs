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
        Task <IEnumerable<Actor>> GetAllAsync();

        //return single actor
        Task<Actor> GetByIdAsync(int id);

        //Adding an actor
        Task AddAsync(Actor actor);
        
        //Update actor
        Task<Actor> UpdateAsync(int id, Actor newActor);

        //Delete Actor
        Task DeleteAsync(int id);
    }
}
