using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IToolsService
    {
        string Hash(string secret);
    }
}
