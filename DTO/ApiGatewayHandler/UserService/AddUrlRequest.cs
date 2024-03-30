namespace Api.UserService
{
    public class AddUrlRequest
    {
        public List<UpdateUrlRequest>? Urls { get; set; }

        public string? ReferenceID { get; set; }
       
    }
}