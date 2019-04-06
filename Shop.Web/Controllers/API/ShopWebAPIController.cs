using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shop.Services;

namespace Shop.Web.Controllers.API
{
    public class ShopWebAPIController : ApiController
    {
        private readonly IBookAppService _bookAppService;

        public ShopWebAPIController(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        [Route("api/getBooks")]
        [HttpGet]
        public IHttpActionResult GetAllBooks(string bookType, bool isNew, bool isUpcoming, bool isSuperOpportunity, string search)
        {
            var x=_bookAppService.GetBooks(bookType, isNew, isUpcoming, isSuperOpportunity, search);
            return Ok(x);
        }
    }
}