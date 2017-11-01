using Sample.Data.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Data
{
    /// <summary>
    /// Data service class from implementing interface methods.
    /// </summary>
    public class DataService : IDataService
    {
        /// <summary>
        /// Get Data from external file or database or data source.
        /// </summary>
        /// <param name="appentStr"></param>
        /// <returns></returns>
        public string getData()
        {
            /*can create connection to database from here with entity framework or sql connection.
               for now using web config to avoid compilation and deployment, can change greet value in config app setting attribute dynamically.
            */
            string _greetLabel = ConfigurationManager.AppSettings.Get("greetText");// 
            _greetLabel = _greetLabel ?? "Hello World";
            return _greetLabel;
        }
    }
}
