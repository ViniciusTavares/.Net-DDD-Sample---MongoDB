using Domain.Models;
using Domain.Mongo.Services.Contracts;
using Module1.Interfaces;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1.Contracts
{
    public class PeopleContract : IPeopleContract
    {  
        public IPeopleService service;

        public PeopleContract(IPeopleService mongoService)
        {
            this.service = mongoService; 
        }

        public People SelectById(long id)
        {
            return service.Single(id); 
        }

        public void Delete(People people)
        {
            service.Delete(people); 
        }

        public void Save(Domain.Models.People people)
        {
            service.Save(people);
        }
    }
}
