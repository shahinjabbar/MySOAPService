using MySOAPService.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySOAPService.Models;
using System.Xml.Linq;
using Microsoft.Extensions.Logging;

namespace MySOAPService.Services
{

    public class SampleService : ISampleService
    {
        private List<MyCustomModel> models;

        public SampleService()
        {
            models = new List<MyCustomModel>()
            {
                new MyCustomModel()
                {
                    Id=1,
                    UserName="Shahin Jabbarov",
                    EmailAdress="shahin.jabarov@accessbak.az"
                },
                new MyCustomModel()
                {
                    Id=2,
                    UserName="Tabriz Badalov",
                    EmailAdress="tabrizvb@code.edu.az"
                },
                 new MyCustomModel()
                {
                    Id=3,
                    UserName="Anar Abishov",
                    EmailAdress="anarra@accessbak.az"
                },
                new MyCustomModel()
                {
                    Id=4,
                    UserName="Elshad Rustemov",
                    EmailAdress="elsahdzr@code.edu.az"
                }
            };
        }

        public IEnumerable<MyCustomModel> GetAll()
        {
            return models;
        }

        public MyCustomModel GetModel(int id)
        {
            MyCustomModel model = models.Find(x=>x.Id==id);

            return model != null ? model : null;
        }

        public string Test(string testinput)
        {

            testinput += " \n Good enough:-)";
            return testinput;
        }
    }
}
