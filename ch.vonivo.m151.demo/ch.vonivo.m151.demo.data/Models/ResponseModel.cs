using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ch.vonivo.m151.demo.data.Models
{
    public class ResponseModel<Tdata>
    {
        public ResponseModel(Tdata data)
        {
            Data = data;
            Success = true;
        }

        //public ResponseModel(string errorCode)
        //{
        //    ErrorCode = errorCode;
        //    Success = false;
        //}

        Tdata Data { get; set; }
        bool Success { get;set; }
        string ErrorCode { get; set; }

    }

    public class ResponseListModel<Tdata>
    {
        public ResponseListModel(IEnumerable<Tdata> data)
        {
            Data = data;
            Success = true;
        }

        //public ResponseModel(string errorCode)
        //{
        //    ErrorCode = errorCode;
        //    Success = false;
        //}

        IEnumerable<Tdata> Data { get; set; }
        bool Success { get; set; }
        string ErrorCode { get; set; }

    }
}
