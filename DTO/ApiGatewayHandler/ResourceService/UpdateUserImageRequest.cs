namespace Api.ResourceService
{
     public class UpdateImageRequest
        {
            public required string UserReferenceId { get; set; }
            public required byte[] Content { get; set; }
        }
}