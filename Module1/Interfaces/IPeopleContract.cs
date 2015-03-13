using MongoDB.Bson;
using System;
namespace Module1.Interfaces
{
    public interface IPeopleContract
    {
        void Delete(Domain.Models.People people);
        void Save(Domain.Models.People people);
        Domain.Models.People SelectById(long id);
    }
}
