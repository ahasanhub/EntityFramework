using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CI.EF.Business.Data;
using CI.EF.Business.Model;
using ContextIdeaData.EF;
using ContextIdeaData.EF.Enums;
using ContextIdeaData.EF.Interfaces;

namespace CI.EF.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context=new BookContext())
            {
                IUnitOfWork unitOfWork=new UnitOfWork(context);
                var book = CreateBook();
                unitOfWork.Repository<Book>().Insert(book);
                unitOfWork.Save();
            }
        }

        static Book CreateBook()
        {
            return new Book
            {
                Name = "Bangla",
                Price = 120m,
                State= ObjectState.Added
            };
        }
    }
}
