using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Service;

namespace BookstoreApp.Controllers
{
    public class BooksController : ApiController
    {
        [Route("api/book/get/{bookId}")]
        public IHttpActionResult GetBookById(int bookID)
        {
            BookService objBook = new BookService();
            BookDTO returnedBook = objBook.GetBookByID(bookID);            
            return this.Ok(returnedBook);
        }

        [Route("api/book/delete/{bookId}")]
        public IHttpActionResult DeleteBookById(int bookID)
        {
            BookService objBook = new BookService();
            objBook.DeleteBook(bookID);
            return this.Ok();
        }

        [Route("api/book/add")]
        public IHttpActionResult AddNewBook(BookDTO NewBook)
        {
            BookService objBook = new BookService();
            objBook.CreateNewBook(NewBook);
            return this.Ok();
        }

        [Route("api/book/update/{newBookInfo}/{bookId}")]
        public IHttpActionResult UpdateBook(BookDTO UpdateBook, int bookID)
        {
            BookService objBook = new BookService();
            objBook.UpdateBook(UpdateBook,bookID);
            return this.Ok();
        }





    }

}

