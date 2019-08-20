using System;
using System.Collections.Generic;
using System.Text;

namespace eXamarin
{
    public interface Message
    {
        void Longtime(string message);
        void Shorttime(string message);
    }
}
