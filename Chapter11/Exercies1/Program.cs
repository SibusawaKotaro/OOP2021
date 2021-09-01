﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Excise1 {
    class Program {
        static void Main(string[] args) {
            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine("------");
            Exercisce1_2(file);
            Console.WriteLine("------");
            Exercisce1_3(file);
            Console.WriteLine("------");
            Exercisce1_4(file);
            Console.WriteLine("------");
        }



        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var sample1 = xdoc.Root.Elements();
            foreach (var sample in sample1) {
                var xname = sample.Element("name");
                var team = sample.Element("teammembers");
                Console.WriteLine("{0},{1}", xname.Value, team.Value);
            }
        }



        private static void Exercisce1_2(string file) {
            var xdoc = XDocument.Load(file);
            var sample2 = xdoc.Root.Elements().OrderBy(x => (string)x.Element("firstplayed"));
            foreach (var sample in sample2) {
                var xname = sample.Element("name").Attribute("kanji");
                Console.WriteLine(xname.Value);
            }
        }

        private static void Exercisce1_3(string file) {
            var xdoc = XDocument.Load(file);
            var sample3 = xdoc.Root.Elements().Select(x => new {
                Name = (string)x.Element("name").Value,
                Team = x.Element("teammembers").Value
            }).OrderByDescending(x => int.Parse(x.Team)).First();
            Console.WriteLine(sample3.Name);
        }

        private static void Exercisce1_4(string file) {
            var newfile = "sports.xml";
            var element = new XElement("novelist", new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                new XElement("teammembers", "11"),
                new XElement("firstplayed", "1863"));

            var xdoc = XDocument.Load("Sample.xml");
            xdoc.Root.Add(element);
            xdoc.Save(newfile);

        }
    }
}