using System.Collections.Generic;
using Shop.Services.Interfaces;

namespace Shop.Services
{
    public class GetBooksOutput
    {
        public List<BookDto> Books { get; set; }
    }
}