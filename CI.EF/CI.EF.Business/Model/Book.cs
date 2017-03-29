using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContextIdeaData.EF;

namespace CI.EF.Business.Model
{
    public class Book: EntityBase
    {
        public int Bookid { get; set; }
        public string  Name { get; set; }
        public decimal Price { get; set; }
    }
}
