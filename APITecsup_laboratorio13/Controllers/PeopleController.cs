using APITecsup_laboratorio13.Models.Request;
using APITecsup_laboratorio13.Models.Response;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace APITecsup_laboratorio13.Controllers
{
    public class PeopleController : ApiController
    {
        // GET: People

        public List<PersonResponse> Get()
        {

            var service = new PersonService();
            var people = service.Get();

            //Convert Domain to Response
            var response = people.Select(x => new PersonResponse
            {
                FullName = string.Concat(x.FirstName, " ", x.LastName)
            }).ToList();

            return response;
        }
        [HttpPost]
        public bool Insert(PersonRequest request)
        {
            var response = true;
            try
            {
                var service = new PersonService();
                service.Insert(new Domain.Person
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName
                });
            }
            catch (Exception)
            {
                //log ex
                response = false;
            }
            return response;
        }







        //public List<PersonResponse> Get()
        //{
        //    var response = new List<PersonResponse>();
        //    response.Add(new PersonResponse { ID = 1, FirstName="Miguel", LastName = "Inga" });
        //    response.Add(new PersonResponse { ID = 2, FirstName="Jhon", LastName = "Inga" });
        //    response.Add(new PersonResponse { ID = 3, FirstName="David", LastName = "Inga" });

        //    return response;
        //}

        //public List<PersonResponse> GetPeople()
        //{
        //    var response = new List<PersonResponse>();
        //    response.Add(new PersonResponse { ID = 1, FirstName = "Miguel", LastName = "Inga" });
        //    response.Add(new PersonResponse { ID = 3, FirstName = "David", LastName = "Inga" });

        //    return response;
        //}

        //[HttpPost]
        //public PersonResponse PostInsert(PersonRequest request)
        //{
        //    var list = new List<PersonResponse>();
        //    list.Add(new PersonResponse { ID = 1, FirstName = "Miguel", LastName = "Inga" });
        //    list.Add(new PersonResponse { ID = 2, FirstName = "Jhon", LastName = "Inga" });
        //    list.Add(new PersonResponse { ID = 3, FirstName = "David", LastName = "Inga" });
        //    list.Add(new PersonResponse { 
        //        ID = 4, 
        //        FirstName = request.FirstName, 
        //        LastName = request.LastName, 
        //        FullName=string.Concat(request.FirstName+" "+ request.LastName)
        //    });

        //    return list.Where(x => x.ID==4).FirstOrDefault();
        //}

        //[HttpGet]
        //public bool Login(string username, string password)
        //{
        //    return username == "minga" && password == "123456";
        //}

    }
}