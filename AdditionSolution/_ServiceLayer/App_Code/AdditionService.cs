using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using _BusinessLayer.Concrete;
using _DataLayer.Models;

namespace _ServiceLayer
{
    public class AdditionService : IAdditionService
    {
        WaiterBusiness wb = new WaiterBusiness();
        DeskBusiness db = new DeskBusiness();
        public Garson GetGarson(string u, string p)
        {
            var waiter = wb.GetWaiter(u, p);
            return new Garson
            {
                Id = waiter.Id,
                Ad = waiter.FirstName,
                Soyad = waiter.LastName
            };
        }

        public List<Masa> Masalar()
        {
            var desks = db.GetDesks();
            List<Masa> list = new List<Masa>();
            foreach (var d in desks)
            {
                list.Add(new Masa
                {
                    Id=d.Id,
                    MasaAdi=d.DeskName
                });
            }
            return list;
        }
    }
}

