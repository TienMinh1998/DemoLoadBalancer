using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class JsonResponseModel : IJsonResponseModel
    {
        public int Status { get; set; }
        public object Data { get; set; } = new object();
        public string Message { get; set; } = string.Empty;
    }
}
