﻿using System.Text;

namespace WithoutInterfaces
{
    public class Logger
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public void Log(string message)
        {
            _stringBuilder.Append(message);
        }

        public override string ToString()
        {
            return _stringBuilder.ToString();
        }
    }
}