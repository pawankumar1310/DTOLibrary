namespace Api.UserService 
{
    public class StatusResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }

        public StatusResponse(bool success, T data)
        {
            Success = success;
            Data = data;
        }

        // Factory methods for success/failure
        public static StatusResponse<T> SuccessStatus(T data)
        {
            return new StatusResponse<T>(true, data);
        }

        public static StatusResponse<T> FailureStatus()
        {
            return new StatusResponse<T>(false, default!);
        }
    }

}