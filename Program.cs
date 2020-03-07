using System;
using System.Linq;
using Newtonsoft.Json;

namespace DictionaryToFlattenList
{
    class Program
    {
        static void Main(string[] args)
        {
            //1: Create a table    
            var dataTable = Initialier.GetAlerLimitTable();

            //2 : from inline data to dictionary
            var dic = dataTable.GetDictionary();
            var dicStr = JsonConvert.SerializeObject(dic);
            Console.WriteLine(dicStr);     

            //2 : from dictionary to inline data
            var list = Transformer.GetTable(dic);

            foreach(var row in list)
            {
                Console.WriteLine(row.ToString());
            }

            //3 Generic method
            var a = dataTable.GroupToDictionary(
                                r => r.RateGroup, 
                                grp => grp.Select(r => new {r.Scenario, r.Year, r.AlertType, r.Value })
                                            .GroupToDictionary(
                                                s => s.Scenario,
                                                grp => grp.Select(r => new {r.Year, r.AlertType, r.Value })
                                                            .GroupToDictionary(
                                                                t => t.Year,
                                                                grp => grp.Select(r => new {r.AlertType, r.Value})
                                                                          .ToDictionary(r => r.AlertType, r => r.Value)
                                                                )
                                                ));

            var aStr = JsonConvert.SerializeObject(a);

            Console.WriteLine(aStr);

            Transformer.Foo(dataTable);
        }
    }
}
