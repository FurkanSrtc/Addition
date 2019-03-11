using _DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BusinessLayer.Concrete
{
    public class WaiterBusiness
    {
        private IRepository<Waiter> _waiterRep;
        private IUnitOfWork _waiterUOF;
        private DbContext _dbContext;
        public WaiterBusiness()
        {
            _dbContext = new AdditionDatabaseEntities();
            _waiterUOF = new EFUnitOfWork(_dbContext);
            _waiterRep = _waiterUOF.GetRepository<Waiter>();
        }


        public Waiter GetWaiter(string username,string password)
        {
            return _waiterRep.Get(w => w.Password == password && w.UserName == username);
        }

    }
}
