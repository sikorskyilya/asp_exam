using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf
{
   
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetAll();

        [OperationContract]
        string AddDict(string surname, int number);

        [OperationContract]
        string UpdDict(int id, string surname, int number);

        [OperationContract]
        string DelDict(int id);
    }
}
