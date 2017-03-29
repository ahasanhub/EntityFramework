using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CI.EF.Business.Data;
using CI.EF.Business.Model;
using ContextIdeaData.EF;
using ContextIdeaData.EF.Interfaces;

namespace CI.EF.WebApi.Controllers
{
    public class BooksController : ApiController
    {
        private IUnitOfWork db = new UnitOfWork(new BookContext());

        // GET: api/Books
        public IQueryable<Book> GetBooks()
        {
            return db.Repository<Book>().Query().Get().AsQueryable();
        }

       
    }
}