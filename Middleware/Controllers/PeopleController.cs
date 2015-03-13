using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain;
using Domain.Models;
using Middleware.Interfaces;
using Module1.Interfaces;
using MongoDB.Bson;

namespace Middleware.Controllers
{
    public class PeopleController : ApiController, IPeopleController
    {
        public IPeopleContract Contract;

        public PeopleController(IPeopleContract contract)
        {
            Contract = contract;
        }

        [HttpGet]
        [HttpDelete]
        public HttpResponseMessage People(long id)
        {
            if (Request.Method.Method == "GET")
            {
                var people = Contract.SelectById(id);

                return Request.CreateResponse(HttpStatusCode.OK, people);
            }
            else
            {
                //People people = new People() { Id = id };

                //Contract.Delete(people); 

                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }

        [HttpPost]
        [HttpPut]
        public HttpResponseMessage People(People people)
        {
            people.UpdateDate = DateTime.Now;

            if (Request.Method.Method == "POST")
            {
                people.InsertDate = DateTime.Now;
            }

            Contract.Save(people);

            return Request.CreateResponse(HttpStatusCode.OK, people);
        }


    }
}