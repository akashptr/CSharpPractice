using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Advance.Linq
{
    internal class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public DateTime PublishDate { get; set; }
        public override string ToString()
        {
            return Title + " " + Price + " " + PublishDate;
        }
    }
}
