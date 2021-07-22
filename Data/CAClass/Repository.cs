using Datien.Data.CAInterface;
using Datien.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Web.Mvc;

namespace Datien.Data.CAClass
{
    public class Repository : IRepository 
    {
        public ApplicationDbContext Context { get; }

        public Repository()
        {

        }

        public Repository(ApplicationDbContext context)
        {
            Context = context;
        }
        public IEnumerable<EducationInstitution> GetData()
        {
            // NORTHWNDEntities context = new NORTHWNDEntities();

            // var query = context.Order_Details.Include("Product")
            //        .GroupBy(p => p.Product.ProductName)
            //        .Select(g => new { name = g.Key, count = g.Sum(w => w.Quantity) }).ToList();
            // return Json(query,JsonRequestBehavior.AllowGet);
            var NewsByGener = (from news in Context.EducationInstitution
                                 where news.InstitutionName == "Alkebulan"
                                 select news).ToList();

            return NewsByGener;
        }
    }
}