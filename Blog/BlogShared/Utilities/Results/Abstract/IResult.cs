using System;
using System.Collections.Generic;
using BlogShared.Utilities.Results.ComplexTypes;

namespace BlogShared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; }
        public string Message { get; }
        public Exception Exception { get; }
    }
}
