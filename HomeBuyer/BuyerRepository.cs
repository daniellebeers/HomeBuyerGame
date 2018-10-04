using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBuyer
{
    class BuyerRepository
    {
        private Buyer _buyer;

        public void CreateBuyer(string name)
        {
            _buyer = new Buyer
            {
                Name = name,
                TourPower = 10,
                PassPower = 10,
                Budget = 30,
                HasMoney = true
            };
        }

        public Buyer BuyerDetails()
        {
            return _buyer;
        }


        public void Tour(int tourPower)
        {
            _buyer.Budget -= tourPower;
        }

        public void Pass(int passPower)
        {
            _buyer.Budget += passPower;
        }
    }
}
