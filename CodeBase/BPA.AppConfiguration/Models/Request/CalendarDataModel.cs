using System.ComponentModel.DataAnnotations;

namespace BPA.AppConfiguration.Models.Request
{
    public class CalendarDataModel
    {
        public int CalID { get; set; }

        public int CalendarID { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string MonthYear { get; set; }
        public string CalendarName { get; set; }
        public string WeekStartDay
        {
            get;
            set;
        }
        public string StartDateofMonth
        {
            get;
            set;
        }
        public string EndDateofMonth
        {
            get;
            set;
        }
        public bool Disabled
        {
            get;
            set;
        }
        public List<Calendarweek> WeekList { get; set; }
    }


    [Serializable]
    public class Calendarweek
    {
        public Calendarweek()
        { }

        public Nullable<int> miWeek { get; set; }

        [DataType(DataType.Date)] // making data type as date     
        public DateTime DisplayEndDate { get; set; }

        [DataType(DataType.Date)] // making data type as date   
        public DateTime DisplayStartDate { get; set; }

        public string msRowState { get; set; }

        public Nullable<int> miCalendarId { get; set; }

        //  public IEnumerable<object> data { get; set; }
    }
}
