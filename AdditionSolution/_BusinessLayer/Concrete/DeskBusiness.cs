using _DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BusinessLayer.Concrete
{
    public class DeskBusiness
    {
        private IRepository<Desk> _deskRep;
        private IUnitOfWork _deskUOF;
        private DbContext _dbContext;

        public IUnitOfWork DeskUOF { get => _deskUOF; set => _deskUOF = value; }

        public DeskBusiness()
        {
            _dbContext = new AdditionDatabaseEntities();
            _deskUOF = new EFUnitOfWork(_dbContext);
            _deskRep = _deskUOF.GetRepository<Desk>();
        }

        public List<Desk> GetDesks()
        {
            return _deskRep.GetAll().ToList();
        }
    }
}
