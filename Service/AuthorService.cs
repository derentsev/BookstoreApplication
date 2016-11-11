using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using AutoMapper;

namespace Service
{
    public class AuthorService
    {
        BookstoreDBEntities AuthorContext = new BookstoreDBEntities();
        /// <summary>
        ///  Connects to the database and returns the Author by its ID.
        /// </summary>
        /// <param name="authorID"></param>
        /// We get  Author`s ID and we use it to find the right element(Author) to return.
        /// <returns></returns>
        /// 

        public AuthorDTO GetAuthorByID(int authorID)
        {
            //var getAuthorById = AuthorContext.spGetAuthorByID(authorID).FirstOrDefault();
            //var authorDto = Mapper.Map<AuthorDTOTEST>(getAuthorById);
            //AuthorDTOTEST returnedDto = AutoMapper.Mapper.Map<AuthorDTOTEST>(getAuthorById);

            var returnauthor = AuthorContext.author_table.Find(authorID);
            AuthorDTO objDTO = new AuthorDTO();
            objDTO.author_age = returnauthor.author_age;
            objDTO.author_country = returnauthor.author_country;
            objDTO.author_name = returnauthor.author_name;

            return objDTO;
        }


        /// <summary>
        /// Connects to the database and adds a new element in it(the database), by getting the new element as a parameter.
        /// </summary>
        /// <param name="newAuthor"></param>
        public void AddNewAuthor(AuthorDTO newAuthor)
        {
            AuthorContext.spAddNewAuthor(newAuthor.author_name, newAuthor.author_age, newAuthor.author_country);
        }


        /// <summary>
        /// Connects to the database and delets and entry by a given ID(as a param).
        /// </summary>
        /// <param name="authorID"></param>
        public void DeleteAuthor(int authorID)
        {
            AuthorContext.spDeleteAuthorByID(authorID);
        }

        /// <summary>
        /// Connects to the database, updating the right entry using an the entrie`s ID(which is a param)  
        /// with new info given as a param of the same type
        /// </summary>
        /// <param name="updateAuthor"></param>
        /// <param name="authorID"></param>
        public void UpdateAuthor(AuthorDTO updateAuthor, int authorID)
        {
            AuthorContext.spUpdateAuthor(updateAuthor.author_name, updateAuthor.author_country, updateAuthor.author_age, authorID);
        }
    }
}
