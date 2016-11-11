using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using BookstoreApp.App_Start;

[assembly: OwinStartup(typeof(BookstoreApp.Startup))]

namespace BookstoreApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
