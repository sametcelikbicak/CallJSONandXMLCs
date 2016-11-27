using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace CallJSONandXMLCs
{
    class Program
    {
        static void Main(string[] args)
        {
            JSONandXMLCs.JSONandXMLSoapClient xmlClient = new JSONandXMLCs.JSONandXMLSoapClient();
            var teamFromXML = xmlClient.GetTeamFromXML();
            Console.WriteLine("XML'den gelen sonuçlar:");
            foreach (var item in teamFromXML)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Position + " " + item.Salary);
            }
            Console.WriteLine();

            JSONandXMLCs.JSONandXMLSoapClient jsonClient = new JSONandXMLCs.JSONandXMLSoapClient();
            var teamFromJSON = jsonClient.GetTeamFromJSON();
            JavaScriptSerializer jss = new JavaScriptSerializer();
            List<Member> members = new List<Member>();
            members = jss.Deserialize<List<Member>>(teamFromJSON);
            Console.WriteLine("JSON'dan gelen sonuçlar:");
            foreach (var item in members)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Position + " " + item.Salary);
            }
            Console.ReadKey();
        }
    }
}
