using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Xml.Serialization.Configuration;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using Castle.Components.DictionaryAdapter;
using Shop.EntityFramework.Entities;
using Shop.EntityFramework.Entities.Base;
using Shop.EntityFramework.Repositories.Interfaces;
using Shop.Services.Dto;
using Shop.Services.Interfaces;
using SimpleTaskSystem;

namespace Shop.Services
{
    public class BookAppService : ApplicationService, IBookAppService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IRepository<Carrier> _carriersRepository;
        private readonly IRepository<Publisher> _publisherRepository;
        private readonly IRepository<Cover> _coversRepository;
        private readonly IRepository<RelEdition> _relEditionsRepository;


        public BookAppService(IBookRepository bookRepository, IRepository<Carrier> carriersRepository,
            IRepository<Publisher> publisherRepository, IRepository<Cover> coversRepository,
            IRepository<RelEdition> relEditionsRepository)
        {
            _bookRepository = bookRepository;
            _carriersRepository = carriersRepository;
            _publisherRepository = publisherRepository;
            _coversRepository = coversRepository;
            _relEditionsRepository = relEditionsRepository;
        }

        [HttpGet]
        public GetBooksOutput GetBooks(string bookType, bool isNew, bool isUpcoming, bool isSuperOpportunity, string search)
        {
            var books = _bookRepository.GetAllBooks();

            if (bookType != null && bookType != "undefined" && bookType != "")
            {
                books = books.FindAll(book => book.BookType.Name == bookType);
            }

            if (isNew)
            {
                books = books.FindAll(book => book.ReleaseDate >= DateTime.Now.AddDays(-14) && book.ReleaseDate <= DateTime.Now);
            }

            if (isUpcoming)
            {
                books = books.FindAll(book => book.ReleaseDate > DateTime.Now && book.ReleaseDate <= DateTime.Now.AddDays(14));
            }
            if (isSuperOpportunity)
            {
                books = books.FindAll(book => book.SuperOpportunity == true);
            }
            if (search != null && search != "undefined" && search != "")
            {

                books = books.FindAll(book => book.BookName.ToLower().Contains(search.ToLower()) || book.Author.Name.ToLower().Contains(search.ToLower()));
            }

            var result = Mapper.Map<List<Book>, List<BookDto>>(books);
            var x = new GetBooksOutput();
            x.Books = result;
            return x;
        }
        [HttpGet]
        public GetMiscOutput GetModalData()
        {
            var result = new GetMiscOutput();

            var publishers = _publisherRepository.GetAllList();
            var covers = _coversRepository.GetAllList();
            var carriers = _carriersRepository.GetAllList();
            var relEditions = _relEditionsRepository.GetAllList();


            result.Carriers = Mapper.Map<List<Carrier>, List<CarrierDto>>(carriers);
            result.Covers = Mapper.Map<List<Cover>, List<CoverDto>>(covers);
            result.Publishers = Mapper.Map<List<Publisher>, List<PublisherDto>>(publishers);
            result.RelEditions = Mapper.Map<List<RelEdition>, List<RelEditionDto>>(relEditions);
            return result;
        }
    }
}
