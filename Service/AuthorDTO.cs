using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace Service
{
    public class AuthorDTO
    {       
        
            public string author_name { get; set; }
            public string author_country{ get; set; }
            public Nullable<byte> author_age { get; set; }
        
    }
}
