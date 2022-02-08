
using RestSharp;
using System;
using System.Configuration;
using ConsoleApp14.Models;
using ConsoleApp14.Clients;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var reqClient = new ReqresInClient();

            var getUserList = reqClient.GetUsersList(1);


            var firstUser = new UsersModelRequest(name: "merworph1eus", job: "lereader");
            var postUser = reqClient.PostUsers(firstUser);


            var getUserById = reqClient.GetSingleUser(10);
            


        }







    }
}