﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Topvisor.Api;
using Topvisor.Xml;

namespace SyncConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var reg = GenTestRegistry(10);

            var config = new ClientConfig("");
            var client = new Client(config);

            //var projects = client.GetProjects();
            var keywords = client.GetKeywords(396790, true);
            var id = client.AddKeywordGroup(396790, "Группа №5");
            client.AddKeywords(396790, id, new [] { "word1", "word2" });

            //var id = client.AddProject("http://ya.ru");
            //client.RemoveProject(id);
            //client.DisableProject(id);

            ////var xmlFile = "project1.xml";
            ////var registry = GetTestRegistry();
            ////registry.Save(xmlFile);
            ////var reg = XmlRegistry.Load(xmlFile);
        }

        private static XmlRegistry GenTestRegistry(int projectsCount)
        {
            var gen = new ProjectGenerator();
            var projects = gen.CreateProjects(projectsCount, projectsCount);
            return new XmlRegistry(projects);
        }
    }
}
