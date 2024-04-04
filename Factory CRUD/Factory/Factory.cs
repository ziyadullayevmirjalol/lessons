using Factory_CRUD.FactoryServices;

namespace Factory_CRUD.Factory
{
    public class Factory : IFactory
    {
        public int ProductID { get; set; }
        private string Product { get; set; }
        private string Details { get; set; }


        public Factory(string productname, string productdetails)
        {
            Product = productname;
            Details = productdetails;
        }

        public Factory()
        {
        }
    }
}

