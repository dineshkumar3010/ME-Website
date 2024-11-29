namespace PropEquityME_DOM
{
    public class Error
    {
        public int Id { get; set; }
        public int Application { get; set; }
        public int ErrorType { get; set; }
        public int UserId { get; set; }
        public string PageName { get; set; }
        public string FilePath { get; set; }
        public string ErrorMessage { get; set; }
        public string StatckTrace { get; set; }
        public DateTime CrOn { get; set; }
    }
}
