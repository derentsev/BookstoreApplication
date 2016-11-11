using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BookDTO
    {
        //public int book_id { get; set; }
        public string book_title { get; set; }
        public string book_genre { get; set; }
        public Nullable<int> book_price { get; set; }
        public int booktore_id { get; set; }
        public int author_id { get; set; }
        //public string author_name { get; set; }
    }
}
