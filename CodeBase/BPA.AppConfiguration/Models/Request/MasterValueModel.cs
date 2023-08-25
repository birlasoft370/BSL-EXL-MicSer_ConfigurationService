using System.Text.Json.Serialization;

namespace BPA.AppConfiguration.Models.Request
{
    public class MasterValueModel
    {
        public MasterValueModel()
        {
            ValueList = new();
        }
        public int MasterValueID
        {
            get;
            set;
        }
        public string MasterType
        {
            get;
            set;
        }
        public bool? Disabled
        {
            get;
            set;
        }


        public List<MasterValueList> ValueList { get; set; }
        public bool ShouldSerializeValueList()
        {
            if (ValueList.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public class MasterValueList
    {
        public int FieldID
        {
            get;
            set;
        }
        public string Values
        {
            get;
            set;
        }
        public bool? Disabled
        {
            get;
            set;
        }
    }
}
