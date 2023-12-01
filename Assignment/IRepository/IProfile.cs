using Assignment.Models;

namespace Assignment.IRepository
{
    // Interface for Profile
    public interface IProfile
    {
        void UpdateProfile(int userId, Profile updatedProfile);
        void DeleteProfile(int userId);
    }
}
