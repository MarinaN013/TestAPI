using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Models
{
    public  class UsersModelRequest
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string name;

        /// <summary>
        /// Работа пользователя
        /// </summary>
        public string job;


        public UsersModelRequest(string name, string job)
        {
            this.name =  name;
            this.job =  job;
        }
    }
    public class UsersModelResponse
    {
        public string name { get; set; }
        public string job { get; set; }
        public string id { get; set; }
        public DateTime createdAt { get; set; }
    }


}
