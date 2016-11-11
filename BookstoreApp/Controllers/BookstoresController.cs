using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Service;

namespace BookstoreApp.Controllers
{
    public class BookstoresController : ApiController
    {
        [Route("api/bookstore/get/{bookstoreID}")]
        public IHttpActionResult GetBookstoreById(int bookstoreID)
        {
            BookstoreService objBookstore = new BookstoreService();
            BookstoreDTO returnedBookstore = objBookstore.GetBookstoreByID(bookstoreID);
            return this.Ok(returnedBookstore);
        }

        [Route("api/bookstore/delete/{bookstoreID}")]
        public IHttpActionResult DeleteBookstoreById(int bookstoreID)
        {
            BookstoreService objBookstore = new BookstoreService();
            objBookstore.DeleteBookstore(bookstoreID);
            return this.Ok();
        }

        [Route("api/bookstore/add")]
        public IHttpActionResult AddNewBookstore(BookstoreDTO NewBookstore)
        {
            BookstoreService objBookstore = new BookstoreService();
            objBookstore.AddNewBookstore(NewBookstore);
            return this.Ok();
        }

        [HttpPut]
        [Route("api/bookstore/update/{bookstoreID}")]
        public IHttpActionResult UpdateBookstore(BookstoreDTO UpdateBookstore, int bookstoreID)
        {
            BookstoreService objBookstore = new BookstoreService();
            objBookstore.UpdateBookstore(UpdateBookstore, bookstoreID);
            return this.Ok();
        }



    }
}
