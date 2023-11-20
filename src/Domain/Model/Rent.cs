using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model;

public class Rent
{
    public User Rentee { get; set; }

    public bool CanReturn(User user) => user is null ?
        throw new ArgumentNullException("user") 
        : user.IsAdmin || Rentee == user;

    public void Assign(User newRentee)
    {
        if (newRentee is null)
            throw new ArgumentNullException();

        this.Rentee = newRentee;   
    }
    
}
