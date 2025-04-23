namespace Pattern.Result
{
    public class ResultValue<TValue>
    {
        protected ResultValue(TValue value, bool isSuccess, string errorMessage = null) : this(isSuccess, errorMessage)
        {
            this.Value = value;
        }
    

        protected ResultValue(bool isSuccess, string errorMessage = null)
        {
            this.IsSuccess = isSuccess;
            this.ErrorMessage = errorMessage;
        }


        public bool IsSuccess { get; }

        public string ErrorMessage { get; }

        public TValue Value { get; set; }

        public static ResultValue<TValue> Success(TValue value) => new ResultValue<TValue>(value, true);

        public static ResultValue<TValue> Failure(string errorMessage) => new ResultValue<TValue>(false, errorMessage);
    }
}
