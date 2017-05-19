using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMY.Castle.FirstStep
{
    public class Intermediary : ILandlordible
    {
        private ILandlordible landlor;

        public Intermediary(ILandlordible landlor)
        {
            this.landlor = landlor;
        }
        public void RentHouse()
        {
            landlor.RentHouse();
            CollectIntermediaryFees();
        }
        private void CollectIntermediaryFees()
        {
            Console.WriteLine("中介收取服务费！");
        }
    }
}
