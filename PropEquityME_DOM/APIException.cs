namespace PropEquityME_DOM
{
    [Serializable]
    public class APIException : System.Exception
    {
        public APIException(string Message, string title) : base(Message)
        {
            this.Title = title;
        }
        public string Title { get; set; }

    }
}
