using Microsoft.AspNetCore.Mvc;

namespace Drizzly.Commons
{
    public static class JsonResultExtensions
    {
        public static JsonResult CreateEmptyResult(ResponseStatus status = ResponseStatus.Success, string message = "")
        {
            return new JsonResult(new
            {
                Status = status.ToString().ToLower(),
                StatusMessage = message,
                Data = ""
            });
        }

        public static JsonResult ToUnifiedResult(this JsonResult result, ResponseStatus status = ResponseStatus.Success,
            string message = "")
        {
            return new JsonResult(new
            {
                Status = status.ToString().ToLower(),
                StatusMessage = message,
                Data = result.Value
            });
        }
    }

    public enum ResponseStatus
    {
        Success,
        Error
    }
}