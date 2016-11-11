using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using AutoMapper;

namespace Service
{
    public class BookstoreService
    {

        BookstoreDBEntities BookstoreContext = new BookstoreDBEntities();

        public BookstoreDTO GetBookstoreByID(int bookstoreID)
        {
            //var getBookstoreById = BookstoreContext.spGetBookstoreByID(bookstoreID).FirstOrDefault();
            //var bookstoreDto = Mapper.Map<BookstoreDTOTEST>(getBookstoreById);
            //BookstoreDTOTEST returnedBookstoreDto = AutoMapper.Mapper.Map<BookstoreDTOTEST>(getBookstoreById);


            var returnBookstore = BookstoreContext.bookstore_table.Find(bookstoreID);
            BookstoreDTO objDTO = new BookstoreDTO();
            objDTO.bookstore_location = returnBookstore.bookstore_location;
            objDTO.bookstore_name = returnBookstore.bookstore_name;
            return objDTO;
        }

        public void AddNewBookstore(BookstoreDTO newBookstore)
        {
            BookstoreContext.AddNewBookstore(newBookstore.bookstore_location, newBookstore.bookstore_name);  
        }

        public void DeleteBookstore(int bookstoreID)
        {
            BookstoreContext.spDeleteBookstoreByID(bookstoreID);
        }

        public void UpdateBookstore(BookstoreDTO updateBookstore, int bookstoreID)
        {
            BookstoreContext.spUpdateBookstore(updateBookstore.bookstore_location, updateBookstore.bookstore_name, bookstoreID);
            
        }



    }
}
