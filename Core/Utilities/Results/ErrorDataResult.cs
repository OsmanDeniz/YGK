using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string msg) : base(false, msg, data)
        {

        }

        public ErrorDataResult(T data) : base(false, data)
        {

        }

        public ErrorDataResult(string msg) : base(false, msg, default)
        {
        }

        public ErrorDataResult() : base(false, default)
        {

        }
    }
}
