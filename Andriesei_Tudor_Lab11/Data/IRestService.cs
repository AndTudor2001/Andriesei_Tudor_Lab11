using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Andriesei_Tudor_Lab11.Models;

namespace Andriesei_Tudor_Lab11.Data
{
    public interface IRestService
    {
        Task <List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
