using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.IRepository
{
    // Interface for Profile
    public interface IProfile
    {
        void UpdateProfile(int userId, Profile updatedProfile);
    }
}
