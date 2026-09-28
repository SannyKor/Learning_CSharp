using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class Error
    {
        public string Message { get; set; } = string.Empty;
        public DateTime Time { get; set; } = DateTime.Now;
        public string Request { get; set; } = string.Empty;
        public StatusCode Status { get; set; }

        public override string ToString()
        {
            return $"[{Time:yyyy-MM-dd HH:mm:ss}] Status: {(int)Status} ({Status}) | Request: {Request} | Message: {Message}";
        }
    }
}
