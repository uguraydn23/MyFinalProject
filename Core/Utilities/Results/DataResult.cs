using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message):base(success,message)
        {

        }

        // T türünde data gönder , ve aynı zamanda bu işlemin sonucunu gönder , base ede implemente edelim ,gönderelim
        public DataResult(T data, bool success):base(success)
        {
            Data = data;
        }

        public T Data { get; }

    }
}
