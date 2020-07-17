using HSC_Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSC_Util
{
    public class ReturnValue<T> : ReturnValue where T :class
    {
        public T Value { get; set; }

        public ReturnValue<T> Fail(string msgformat, params object[] args)
        {
            Msg = string.Format(msgformat, args);
            StatusCode = Status.ERROR;
            return this;
        }

        public void Success()
        {
            StatusCode = Status.SUCCESS;
        }

        public ReturnValue<T> Success(T value, string msg = "")
        {
            Msg = msg;
            Value = value;
            StatusCode = Status.SUCCESS;
            return this;
        }

        public ReturnValue<T> Success(T value, string msg = "", params object[] args)
        {
            Msg = string.Format(msg, args);
            Value = value;
            StatusCode = Status.SUCCESS;
            return this;
        }
    }
    public class ReturnValue
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public Status StatusCode { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }

        public ReturnValue Fail(string msg = "")
        {
            Msg = msg;
            StatusCode = Status.ERROR;
            return new ReturnValue() { StatusCode = Status.ERROR, Msg = msg };
        }

        public ReturnValue Fail(string msg = "", params object[] args)
        {
            Msg = string.Format(msg, args);
            StatusCode = Status.ERROR;
            return this;
        }

        public ReturnValue Success(string msg = "")
        {
            this.Msg = msg;
            StatusCode = Status.SUCCESS;
            return this;
        }

        public ReturnValue Success(string msg = "", params object[] args)
        {
            Msg = string.Format(msg, args);
            StatusCode = Status.SUCCESS;
            return this;
        }

        public bool IsSuccess
        {
            get
            {
                return this.StatusCode == Status.SUCCESS;
            }
        }

        public static ReturnValue SetFail(string msgformat, params object[] args)
        {
            return new ReturnValue() { StatusCode = Status.SUCCESS, Msg = string.Format(msgformat, args) };
        }

        public static ReturnValue SetSuccess(string msgformat, params object[] args)
        {
            return new ReturnValue() { StatusCode = Status.SUCCESS, Msg = string.Format(msgformat, args) };
        }
    }
}
