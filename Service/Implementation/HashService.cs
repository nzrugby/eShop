using Service.Interface;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Service.Implementation
{
    public class ToolsService : IToolsService
    {
        public string Hash(string secret)
        {
            var sha256 = SHA256.Create();
            var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(secret));
            return BitConverter.ToString(hashedBytes).Replace("-","").ToLower();
        }
    }
}
