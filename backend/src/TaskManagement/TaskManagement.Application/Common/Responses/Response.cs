﻿namespace TaskManagement.Application.Common.Responses
{
    public class Response<T> : BaseResponse
    {
        public T Data { get; set; }
    }
}
