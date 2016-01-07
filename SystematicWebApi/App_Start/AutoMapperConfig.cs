using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SystematicWebApi.Models.Products;
using AutoMapper;
using Common;
using Domain.Entity;

namespace SystematicWebApi.Infrastructure
{
    public static class AutoMapperConfig
    {

        public static void Config()
        {
            new ObjectMapping().MapperConfig();
        }
    }
}