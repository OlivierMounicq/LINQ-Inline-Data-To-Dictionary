using System.Collections.Generic;

namespace DictionaryToFlattenList
{
    public class Initialier
    {
        public static IList<AlertLimitRow> GetAlerLimitTable()
        {
            var table = new List<AlertLimitRow>();
            //Group
            table.Add(new AlertLimitRow{
                Id = 1,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.Group,
                Scenario = Scenario.RasUpward,
                AlertType = AlertType.Alert,
                Year = YearIndex.Year1,
                Value = 1.1m
            });        

            table.Add(new AlertLimitRow{
                Id = 2,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.Group,
                Scenario = Scenario.RasUpward,
                AlertType = AlertType.Limit,
                Year = YearIndex.Year1,
                Value = 1.2m
            });

            table.Add(new AlertLimitRow{
                Id = 2,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.Group,
                Scenario = Scenario.RasUpward,
                AlertType = AlertType.Alert,
                Year = YearIndex.Year2,
                Value = 1.3m
            });        

            table.Add(new AlertLimitRow{
                Id = 4,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.Group,
                Scenario = Scenario.RasUpward,
                AlertType = AlertType.Limit,
                Year = YearIndex.Year2,
                Value = 1.4m
            });

            table.Add(new AlertLimitRow{
                Id = 5,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.Group,
                Scenario = Scenario.RasUpward,
                AlertType = AlertType.Alert,
                Year = YearIndex.Year3,
                Value = 1.5m
            });        

            table.Add(new AlertLimitRow{
                Id = 6,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.Group,
                Scenario = Scenario.RasUpward,
                AlertType = AlertType.Limit,
                Year = YearIndex.Year3,
                Value = 1.6m
            });

            table.Add(new AlertLimitRow{
                Id = 7,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.Group,
                Scenario = Scenario.RasDownward,
                AlertType = AlertType.Alert,
                Year = YearIndex.Year1,
                Value = 1.01m
            });        

            table.Add(new AlertLimitRow{
                Id = 8,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.Group,
                Scenario = Scenario.RasDownward,
                AlertType = AlertType.Limit,
                Year = YearIndex.Year1,
                Value = 1.02m
            });

            table.Add(new AlertLimitRow{
                Id = 9,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.Group,
                Scenario = Scenario.RasDownward,
                AlertType = AlertType.Alert,
                Year = YearIndex.Year2,
                Value = 1.03m
            });        

            table.Add(new AlertLimitRow{
                Id = 10,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.Group,
                Scenario = Scenario.RasDownward,
                AlertType = AlertType.Limit,
                Year = YearIndex.Year2,
                Value = 1.04m
            });

            table.Add(new AlertLimitRow{
                Id = 11,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.Group,
                Scenario = Scenario.RasDownward,
                AlertType = AlertType.Alert,
                Year = YearIndex.Year3,
                Value = 1.05m
            });        

            table.Add(new AlertLimitRow{
                Id = 12,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.Group,
                Scenario = Scenario.RasDownward,
                AlertType = AlertType.Limit,
                Year = YearIndex.Year3,
                Value = 1.06m
            });

           //DM
            table.Add(new AlertLimitRow{
                Id = 10,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.DM,
                Scenario = Scenario.RasUpward,
                AlertType = AlertType.Alert,
                Year = YearIndex.Year1,
                Value = 10.1m
            });        

            table.Add(new AlertLimitRow{
                Id = 20,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.DM,
                Scenario = Scenario.RasUpward,
                AlertType = AlertType.Limit,
                Year = YearIndex.Year1,
                Value = 20.2m
            });

            table.Add(new AlertLimitRow{
                Id = 30,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.DM,
                Scenario = Scenario.RasUpward,
                AlertType = AlertType.Alert,
                Year = YearIndex.Year2,
                Value = 30.3m
            });        

            table.Add(new AlertLimitRow{
                Id = 40,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.DM,
                Scenario = Scenario.RasUpward,
                AlertType = AlertType.Limit,
                Year = YearIndex.Year2,
                Value = 40.4m
            });

            table.Add(new AlertLimitRow{
                Id = 50,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.DM,
                Scenario = Scenario.RasUpward,
                AlertType = AlertType.Alert,
                Year = YearIndex.Year3,
                Value = 50.5m
            });        

            table.Add(new AlertLimitRow{
                Id = 60,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.DM,
                Scenario = Scenario.RasUpward,
                AlertType = AlertType.Limit,
                Year = YearIndex.Year3,
                Value = 60.6m
            });
            
            table.Add(new AlertLimitRow{
                Id = 70,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.DM,
                Scenario = Scenario.RasDownward,
                AlertType = AlertType.Alert,
                Year = YearIndex.Year1,
                Value = 70.07m
            });        

            table.Add(new AlertLimitRow{
                Id = 80,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.DM,
                Scenario = Scenario.RasDownward,
                AlertType = AlertType.Limit,
                Year = YearIndex.Year1,
                Value = 80.08m
            });

            table.Add(new AlertLimitRow{
                Id = 90,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.DM,
                Scenario = Scenario.RasDownward,
                AlertType = AlertType.Alert,
                Year = YearIndex.Year2,
                Value = 90.09m
            });        

            table.Add(new AlertLimitRow{
                Id = 100,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.DM,
                Scenario = Scenario.RasDownward,
                AlertType = AlertType.Limit,
                Year = YearIndex.Year2,
                Value = 100.1m
            });

            table.Add(new AlertLimitRow{
                Id = 110,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.DM,
                Scenario = Scenario.RasDownward,
                AlertType = AlertType.Alert,
                Year = YearIndex.Year3,
                Value = 11.11m
            });        

            table.Add(new AlertLimitRow{
                Id = 120,
                PeriodId = 123,
                RateGroup = RateGroupLevel1.DM,
                Scenario = Scenario.RasDownward,
                AlertType = AlertType.Limit,
                Year = YearIndex.Year3,
                Value = 12.12m
            });


            return table;
        }

    }

}