using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Wrappers
{
    public class BaseResponse<T>
    {
        
        public T Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }

        public BaseResponse(T data,string message)
        {
            Data = data;
            Message = message;
        }

        public BaseResponse(T data,  string message,bool success)
        {
            Data = data;
            Success = success;
            Message = message;
        }
        public BaseResponse()
        {
            
        }
    }
}
