using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Shop.Services.Interfaces;

namespace Shop.Services
{
    public interface IBookAppService : IApplicationService
    {
        GetBooksOutput GetBooks(string bookType, bool isNew, bool isUpcoming, bool isSuperOpportunity, string search);
        GetMiscOutput GetModalData();
    }
}
