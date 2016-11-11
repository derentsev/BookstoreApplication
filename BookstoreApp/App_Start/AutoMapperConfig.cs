using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Service;
using DAL;
using System.Reflection;
using System.Configuration;
using System.Web.Mvc;


namespace BookstoreApp.App_Start
{
    public static class AutoMapperConfig
    {
        //ActualAutoMapper
        //public  Execute(params string[] assemblies)
        //{
        //    var Configuration  = new MapperConfiguration(
        //        cfg =>
        //        {
        //            cfg.ConstructServicesUsing(t => DependencyResolver.Current.GetService(t));
        //            var types = new List<Type>();
        //            foreach (var assembly in assemblies.Select(a => Assembly.Load(a)))
        //            {
        //                types.AddRange(assembly.GetExportedTypes());
        //            }

        //        });
        //}
        public static void Execute()
        {
            AutoMapper.Mapper.Initialize(y => y.CreateMap<AuthorDTO, author_table>());
            AutoMapper.Mapper.Initialize(y => y.CreateMap<author_table, AuthorDTO>());
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<spGetAuthorByID_Result, AuthorDTO>());
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<AuthorDTO, spGetAuthorByID_Result>());
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<spGetBookByID_Result, BookDTO>());
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<BookDTO, spGetBookByID_Result>());
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<spGetBookstoreByID_Result, BookstoreDTO>());
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<BookstoreDTO, spGetBookstoreByID_Result>());
        }
    }
}

