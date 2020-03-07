using System.Collections.Generic;

namespace DictionaryToFlattenList
{
    public enum RateGroupLevel1
    {
        Group,
        DM,
        IFS,
        CIB
    }

    public enum Scenario
    {
        RasUpward,
        RasDownward
    }

    public enum AlertType
    {
        Alert,
        Limit
    }

    public enum YearIndex
    {
        Year1,
        Year2,
        Year3
    }

    public class AlertLimitDictionary : Dictionary<RateGroupLevel1, Dictionary<Scenario, Dictionary<YearIndex, Dictionary<AlertType, decimal>>>> { }
    public class AlertAndLimitDictionary : Dictionary<RateGroupLevel1, AlertAndLimitScenarioDictionary> {}
    public class AlertAndLimitScenarioDictionary : Dictionary<Scenario, AlertAndLimitYearDictionary>{}
    public class AlertAndLimitYearDictionary : Dictionary<YearIndex, AlertAndLimitAlertTypeDictionary>{}
    public class AlertAndLimitAlertTypeDictionary : Dictionary<AlertType, decimal>{}

    public class AlertLimitRow
    {
        public int Id {get; set;} 
        public int PeriodId { get; set;}
        public RateGroupLevel1 RateGroup { get; set;}
        public Scenario Scenario { get; set;}
        public AlertType AlertType { get; set;}
        public YearIndex Year { get; set;}
        public decimal Value { get; set;}

        public AlertLimitRow(){}

        public AlertLimitRow(RateGroupLevel1 rateGrp, Scenario scenario, YearIndex yearIndex, AlertType alertType, decimal value)
        {
            this.RateGroup = rateGrp;
            this.Scenario = scenario;
            this.AlertType = alertType;
            this.Year = yearIndex;
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.RateGroup.ToString()} - {this.Scenario.ToString()} - {this.Year.ToString()} - {this.AlertType.ToString()} - {this.Value.ToString()}";
        }
    }
}