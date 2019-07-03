using MySOAPService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace MySOAPService.Infrastructures
{
    [ServiceContract(ConfigurationName = "MyCustomService")]
    public interface ISampleService
    {
        [OperationContract]
        string Test(string testinput);

        [OperationContract]
        MyCustomModel GetModel(int id);

        [OperationContract]
        IEnumerable<MyCustomModel> GetAll();
    }
}
