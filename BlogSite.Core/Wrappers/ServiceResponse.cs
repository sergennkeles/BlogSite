using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Wrappers
{
    public class ServiceResponse<T>:BaseResponse<T>
        
    {

        public ServiceResponse(T data,  string message) : base(data,message,true)
        {
        }
       


    }
}
