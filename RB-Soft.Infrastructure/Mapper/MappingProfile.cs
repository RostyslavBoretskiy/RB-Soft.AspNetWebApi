using AutoMapper;

using System.Collections.Generic;

namespace RB_Soft.Infrastructure.Mapper
{
    public static class MappingProfile
    {
        public static List<Profile> GetDataProfiles()
        {
            var profiles = new List<Profile>();

            //profiles.Add(new IncidentProfile());

            return profiles;
        }
    }
}
