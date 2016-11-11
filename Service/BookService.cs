using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using DAL;
using AutoMapper;

namespace Service
{
    public class BookService
    {
        BookstoreDBEntities BookContext = new BookstoreDBEntities();

        public BookDTO GetBookByID(int bookID)
        {
            //MapperNotWorking???
            //var getBookById = BookContext.spGetBookByID(bookID).FirstOrDefault();            
            //var bookDto = Mapper.Map<BookDTOTEST>(getBookById);
            //BookDTOTEST returnedBookDto = AutoMapper.Mapper.Map<BookDTOTEST>(getBookById);

            var returnBook = BookContext.book_table.Find(bookID);
            BookDTO objDTO = new BookDTO();
            objDTO.book_genre = returnBook.book_genre;
            objDTO.book_price = returnBook.book_price;
            objDTO.book_title = returnBook.book_title;


            return objDTO;
            //return returnedBookDto; 
        }

         //CheckError?
        public void CreateNewBook(BookDTO newBook)
        {
            BookContext.spAddNewBook(newBook.book_title, newBook.book_price, newBook.book_genre, newBook.booktore_id, newBook.author_id);
        }

        public void DeleteBook(int bookID)
        {
            BookContext.spDeleteBookByID(bookID);
        }
        

        public void UpdateBook(BookDTO updateBook, int bookID)
        {
            BookContext.spUpdateBook(updateBook.book_title, updateBook.book_genre, updateBook.book_price, bookID);            
        }

    }
}
