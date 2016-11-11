using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Service;

namespace BookstoreApp.Controllers
{
    public class AuthorsController : ApiController
    {  
        /// <summary>
        /// Calls a service method. The method get the Author by ID from the body.
        /// </summary>
        /// <param name="authorID"></param>
        /// <returns></returns>
        [Route("api/author/get/{authorId}")]
        public IHttpActionResult GetAutorById(int authorID)
        {
            AuthorService objAuthor = new AuthorService();
            AuthorDTO returnedAuthor = objAuthor.GetAuthorByID(authorID);
            return this.Ok(returnedAuthor);
        }

        /// <summary>
        /// Calls a Service method to delete an entry by its ID. We get the ID from the body.
        /// </summary>
        /// <param name="authorID"></param>
        /// <returns></returns>
        [Route("api/author/delete/{authorId}")]
        public IHttpActionResult DeleteAuthorById(int authorID)
        {
            AuthorService objAuthor = new AuthorService();
            objAuthor.DeleteAuthor(authorID);
            return this.Ok();
        }

        /// <summary>
        /// Calls a Service method to add a new entry. We get the new entry data from the body.
        /// </summary>
        /// <param name="NewAuthor"></param>
        /// <returns></returns>
        [Route("api/author/add")]
        public IHttpActionResult AddNewAuthor(AuthorDTO NewAuthor)
        {
            AuthorService objAuthor = new AuthorService();
            objAuthor.AddNewAuthor(NewAuthor);
            return this.Ok();
        }

        /// <summary>
        /// Calls a Service method to update an existing entry. Uses ID  from body to find the right entry, 
        /// and recieves the update info from the body as well.
        /// </summary>
        /// <param name="UpdateAuthor"></param>
        /// <param name="authorID"></param>
        /// <returns></returns>
        /// 
        [HttpPut]
        [Route("api/author/update/{authorId}")]
        public IHttpActionResult UpdateAuthor([FromBody] AuthorDTO UpdateAuthor, int authorID)
        {
            AuthorService objAutor = new AuthorService();
            objAutor.UpdateAuthor(UpdateAuthor, authorID);
            return this.Ok();
        }

    }
}
