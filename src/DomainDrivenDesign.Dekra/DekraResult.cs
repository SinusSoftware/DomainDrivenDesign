namespace DomainDrivenDesign.Dekra
{
    public class RawDekraCalculations
    {
        public string drs1p { get; set; }
        public string drsll { get; set; }
        public string drs2p { get; set; }
        public string drs1l { get; set; }
        public string drs2l { get; set; }
        public string location { get; set; }
        public string id { get; set; }
        public string zip_code { get; set; }
        public string drslp { get; set; }
    }

    public class RawDekraSearch
    {
        public List<object> next_results { get; set; }
        public List<object> previous_results { get; set; }
        public string query { get; set; }
        public int number_of_results { get; set; }
        public string time { get; set; }
        public string load_more_url { get; set; }
        public List<RawDekraCalculations> results { get; set; }
        public int current_page { get; set; }
    }

    public class RawDekraCalculationResult
    {
        public RawDekraSearch DekraSearch { get; set; }
    }
}
