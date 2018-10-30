using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IUser
    {
        Guid Id { get; set; }
        string UserName { get; set; }
        string Email { get; set; }

    }
}
