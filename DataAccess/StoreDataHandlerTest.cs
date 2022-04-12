using api.Interfaces;
using api.Models;
using System.Collections.Generic;

namespace api.DataAccess
{
    public class StoreDataHandlerTest : IStoreDataHandler
    {
        public List<Store> GetAllStores()
        {
            List<Store> myStores = new List<Store>();
            myStores.Add(new Store(){id=1,addressLineOne="123 Dirt Road",addressLineTwo="",city="Clanton",state="AL",zip=35045});
            myStores.Add(new Store(){id=2,addressLineOne="4300 Cross Keys",addressLineTwo="",city="Birmingham",state="AL",zip=35213});
            myStores.Add(new Store(){id=1,addressLineOne="21 Bumpy Rd",addressLineTwo="Box 1313",city="Tuscaloosa",state="AL",zip=35401});
            return myStores;
        }
        public Store GetStore(int id)
        {
            return new Store();
        }
        public void UpdateStore(Store value)
        {
            System.Console.WriteLine(value.addressLineOne);
        }
        public void CreateStore(Store value)
        {
            System.Console.WriteLine(value.addressLineOne);
        }
        public void DeleteStore(int id)
        {
            System.Console.WriteLine(id);
        }
    }
}