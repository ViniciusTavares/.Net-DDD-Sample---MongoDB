using Domain.Models;
using Domain.Mongo.Services.Contracts;
using Infrastructure.MongoDB.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mongo.Services.Services
{
    public class PeopleService : BaseDomainService<People>, IPeopleService
    {
        public PeopleService(IUnitOfWork uow) : base(uow) { }
    }
}
