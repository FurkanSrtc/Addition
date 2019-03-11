using _DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace _ServiceLayer
{
    [ServiceContract]
    public interface IAdditionService
    {
        [OperationContract]
        Garson GetGarson(string u, string p);
        [OperationContract]
        List<Masa> Masalar();
    }
}


