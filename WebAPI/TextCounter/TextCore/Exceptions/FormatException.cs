using System;
using System.Collections.Generic;
using System.Text;

namespace TextCore.Exceptions
{
    public class FormatException : Exception
    {
        public FormatException(string base64) : base($"Base64 input {base64} is not in the valid format")
        {

        }
    }
}
