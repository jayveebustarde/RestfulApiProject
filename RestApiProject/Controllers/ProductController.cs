﻿using DTO;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApiProject.Controllers
{
    public class ProductController : BaseController<ProductDTO>
    {
        public ProductController(IBaseService<ProductDTO> service) : base(service)
        {

        }
    }
}
