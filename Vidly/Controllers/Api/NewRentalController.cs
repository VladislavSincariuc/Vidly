﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Glimpse.Mvc.AlternateType;
using Vidly.Dtos;

namespace Vidly.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            throw  new NotImplementedException();
        }
    }
}