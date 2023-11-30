﻿using Assignment.IRepository; // Assuming this is the namespace where IProfile is defined
using Assignment.Models;
using System.Collections.Generic;

namespace Assignment.Repository
{
    // ProfileRepository class implementing IProfile interface
    public class ProfileRepository : IProfile
    {
        private List<Profile> profiles = new List<Profile>();

        public void UpdateProfile(int userId, Profile updatedProfile)
        {
            var profileIndex = profiles.FindIndex(p => p.UserId == userId);
            if (profileIndex != -1)
            {
                profiles[profileIndex] = updatedProfile;
            }
        }
    }
}