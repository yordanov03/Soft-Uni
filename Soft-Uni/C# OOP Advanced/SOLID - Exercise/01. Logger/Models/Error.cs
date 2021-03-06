﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Models
{
    using Models.Contracts;
    public class Error:IError
    {
        public Error (DateTime dateTime, ErrorLevel level, string message)
        {
            this.DateTime = dateTime;
            this.Level = level;
            this.Message = message;
        }
        public DateTime DateTime { get; }
        public string Message { get; }
        public ErrorLevel Level { get; }
    }
}
