using Module1.Contracts;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module1.Interfaces;
using Infrastructure.MongoDB.Data.Contracts;
using Infrastructure.MongoDB.Data.Config;
using Domain.Mongo.Services.Contracts;
using Domain.Mongo.Services.Services;

namespace Infrastructure.CrossCutting
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(t =>
            {
               
                t.For(typeof(IUnitOfWork)).Use(typeof(UnitOfWork));

                // Domain.Services
                t.For(typeof(IPeopleService)).Use(typeof(PeopleService)); 

                // Modules
                t.For(typeof(IPeopleContract)).Use(typeof(PeopleContract)); 
            });

            return ObjectFactory.Container;
        }
    }
}
