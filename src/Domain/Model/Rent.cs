using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model;

public class Rent
{
    public User Rentee { get; set; }

    public bool CanReturn(User user)
    {
        if (user == null)
            throw new ArgumentNullException("user");

        return user.IsAdmin || Rentee == user;
    }
}
