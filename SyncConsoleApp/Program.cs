﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopvisorApi;

namespace SyncConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ClientConfig("");

            var client = new Client(config);

            var projects = client.GetProjects();
            var keywords = client.GetKeywords(396790);
        }
    }
}
