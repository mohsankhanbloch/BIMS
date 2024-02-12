namespace BIMS.Server.Common
{
    public class BaseResponse
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public object Data{ get; set; }
    }
}
