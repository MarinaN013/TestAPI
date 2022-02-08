using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using ConsoleApp14.Models;
using RestSharp;

namespace ConsoleApp14.Clients
{
    public class ReqresInClient
    {
        private class ReqresClient client;

            public ReqresInClient()
        {
            var baseUrl = ConfigurationManager.AppSettings("url");
            this.client = new RestClient(baseUrl);
        }
        public UsersModelResponse PostUsers(UsersModelRequest requestBody)
        {
            var url = "/api/users";
            var request2 = new RestRequest(url, Method.Post, DataFormat.Json);
            request2 = AddJsonBody(requestBody);
            return client.Execute<UsersListModelResponse>(request2).Data;

        }
        public UsersListModelResponse GetUsersList(int page)
        {
            var url = $"/api/users?page={page}";
            var request = new RestRequest(url, Method.Get);
            return client.Execute<UsersListModelResponse>(request).Data;
        }

        public SingleUserResponse GetSingleUser(int userId)
        {
            var url = $"/api/users{userId}";
            var request = new RestRequest(url, Method.Get);
            return client.Execute<SingleUserResponse>(request).Data;
        
        }

    }

}
