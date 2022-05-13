
namespace Core
{
    public interface IJsonResponseModel
    {
        object Data { get; set; }
        string Message { get; set; }
        int Status { get; set; }

    }
}