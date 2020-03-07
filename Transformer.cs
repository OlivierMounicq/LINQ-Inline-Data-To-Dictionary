using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DictionaryToFlattenList
{
    public static class Transformer
    {
        public static Dictionary<RateGroupLevel1, Dictionary<Scenario, Dictionary<YearIndex, Dictionary<AlertType, decimal>>>> GetDictionary(this IEnumerable<AlertLimitRow> table)
        {
            var dic = table
                        .Where(r => r.PeriodId == 123)        
                        .GroupBy
                        (
                            r => r.RateGroup,
                            r => r,
                            (key, val)  => new 
                            {
                                RateGroup = key,
                                Data = val.Select(r => new {r.Scenario, r.Year, r.AlertType, r.Value})
                                        .GroupBy
                                        (
                                            s => s.Scenario,
                                            s => s,
                                            (k,v) => new
                                            {
                                                Scenario = k,
                                                DataPerScenario = v.Select(t => new { t.Year, t.AlertType, t.Value })
                                                                    .GroupBy
                                                                    (
                                                                        t => t.Year,
                                                                        t => t,
                                                                        (tK,tV) => new 
                                                                        {
                                                                            Year = tK,
                                                                            DataPerYear = tV.ToDictionary(a => a.AlertType, a => a.Value)
                                                                        }     
                                                                    )
                                                                    .ToDictionary(t => t.Year, t => t.DataPerYear)

                                            }        
                                        )
                                        .ToDictionary(t => t.Scenario, t => t.DataPerScenario)
                            }      
                        )
                        .ToDictionary(s => s.RateGroup, s => s.Data);

            return dic;            
        }

        public static IEnumerable<AlertLimitRow> GetTable(Dictionary<RateGroupLevel1, Dictionary<Scenario, Dictionary<YearIndex, Dictionary<AlertType, decimal>>>> dic)
        {
            return dic.SelectMany(a => a.Value.SelectMany(b => b.Value.SelectMany(c => c.Value.Select(d => 
                new AlertLimitRow(a.Key, b.Key, c.Key, d.Key, d.Value)
            ))));        
        }

        public static IDictionary<K,V> GroupToDictionary<T,K,V>(
            this IEnumerable<T> source, 
            Func<T,K> keySelector,
            Func<IGrouping<K,T>, V> valueSelector)
            => source.GroupBy(keySelector)
                    .ToDictionary(x => x.Key, valueSelector);


        public static void Foo(IEnumerable<AlertLimitRow> table)
        {
            var z = table.GroupBy(t => t.RateGroup);
        }

        /**
        private static object AppendData<K,V>(IDictionary<K,V> dic, IDictionary<string, object> info)
        {
            //si la valeur est un dictionnaire alors on continue à plonger dans le graphe
            if(typeof(V) == typeof(Dictionary<,>))
            {   
                foreach(var key in dic.Keys)
                {

                    info.Add(key.GetType().Name , key);

                    Type[] arguments = dic[key].GetType().GetGenericArguments();
                    Type K1 = arguments[0];
                    Type V1 = arguments[1];

                    AppendData(dic[key] as IDictionary<K1.GetType(),V1.GetType()>, info);
                }       
            }
            else
            {
                yield return GenerateAlertLimitRow(info);        
            }
        }

        private static AlertLimitRow GenerateAlertLimitRow(IDictionary<string, object> info)
        {
            var obj = new AlertLimitRow();

            foreach(var propertyValue in info)
            {
                PropertyInfo propertyInfo = typeof(AlertLimitRow).GetProperty(propertyValue.Key);
                propertyInfo.SetValue(obj, propertyValue.Value, null);
            }

            return obj;
        }
        **/
    }
}