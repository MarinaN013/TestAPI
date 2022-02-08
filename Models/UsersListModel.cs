using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp14.Models.UsersListModelResponse;

namespace ConsoleApp14.Models
{
    public class UsersListModelResponse
    {
        public class Datum
        {
            public int id { get; set; }
            public string email { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string avatar { get; set; }
        }

        public class Support
        {
            public string url { get; set; }
            public string text { get; set; }
        }

        
    }

    public class UsersListModelResponse
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Datum> data { get; set; }
        public Support support { get; set; }
    }

    public class SingleUserResponse
    {
       
        public Support support { get; set; }
        public Datum data { get; set; }
    }
}
