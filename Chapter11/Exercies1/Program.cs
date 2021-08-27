﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercies1 {
    class Program {
        static void Main(string[] args) {
            var file = "Sample.xml";
            Exercies1_1(file);
            Console.WriteLine("----------");

            Exercies1_2(file);
            Console.WriteLine("----------");

            Exercies1_3(file);
            Console.WriteLine("----------");

        }

        private static void Exercies1_1(string file) {
            var xdoc = XDocument.Load(file);
            var sample1 = xdoc.Root.Elements();
            foreach (var sample in sample1) {
                var xname = sample.Element("name");
                var team = sample.Element("teammembers");
                Console.WriteLine("{0},{1}", xname.Value, team.Value);
            }
        }

        private static void Exercies1_2(string file) {
            var xdoc = XDocument.Load(file);
            var sample2 = xdoc.Root.Elements().OrderBy(x => (string)x.Element("firstplayed"));
            foreach (var sample in sample2) {
                var xname = sample.Element("name").Attribute("kanji");
                Console.WriteLine(xname.Value);
            }
        }

        private static void Exercies1_3(string file) {
            var xdoc = XDocument.Load(file);
        }
    }
}


