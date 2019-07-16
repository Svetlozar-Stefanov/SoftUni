using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Interfaces
{
    public interface IBirthable
    {
        string Birthdate { get; }

        bool CheckBirthdate(string date);
    }
}
