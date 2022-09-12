using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string mesaage):base(data, true, mesaage)
        {

        }
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        public SuccessDataResult(string mesaage):base(default, true, mesaage)
        {

        }
        public SuccessDataResult():base(default, true)
        {

        }
    }
}
