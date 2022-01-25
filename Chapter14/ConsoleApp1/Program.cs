using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            using (var client = new HttpClient()) {

                using (WebClient webClient = new WebClient()) {
                    webClient.Encoding = System.Text.Encoding.UTF8;
                    //var url = webClient.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=975b01c0f41d3986&lat=33.590543&lng=130.420096&range=2&order=1&format=json");
                    //var url = "http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=975b01c0f41d3986&lat=36.30930345967539&lng=139.3918060634633&range=4&order=3&large_area&middle_area&small_area&format=json";

                    var unko = "http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=975b01c0f41d3986&lat=36.30930345967539&lng=139.3918060634633&range=5&order=1&format=json";
                    var Jsonurl = webClient.DownloadString(unko);
                    var json = JObject.Parse(Jsonurl);
                    
                    foreach (var e in json) {
                        Console.WriteLine(e);
                    }
                    Console.ReadLine();


                }
            }
        }           
    }
}
