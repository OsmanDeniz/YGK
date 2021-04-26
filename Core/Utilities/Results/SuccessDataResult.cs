using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string msg) : base(true, msg, data)
        {

        }

        public SuccessDataResult(T data) : base(true, data)
        {

        }

        public SuccessDataResult(string msg) : base(true, msg, default)
        {
        }

        public SuccessDataResult():base(true,default)
        {
            
        }
    }
}
