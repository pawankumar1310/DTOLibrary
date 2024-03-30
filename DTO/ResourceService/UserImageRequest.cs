
namespace DTO.ResourceService
{
    public class UserImageRequest
    {
        public string Label { get; set; }
        public string Name { get; set; }
        public byte[] Content { get; set; }
        public string UserReferenceId { get; set; }

    }
}
