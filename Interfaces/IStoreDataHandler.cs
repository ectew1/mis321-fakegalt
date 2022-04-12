using System;
using api.Models;
using System.Collections.Generic;

namespace api.Interfaces
{
    public interface IStoreDataHandler
    {
         public List<Store> GetAllStores();
         public Store GetStore(int id);
         public void UpdateStore(Store value);
         public void CreateStore(Store value);
         public void DeleteStore(int id);

    }
}