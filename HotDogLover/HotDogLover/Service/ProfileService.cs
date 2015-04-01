using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotDogLover.Models;

namespace HotDogLover.Service
{
    public class ProfileService
    {
        private static List<Profile> profiles;
        private static HotdogsService hotdogService;
        static ProfileService()
        {
            reload();
        }


        public List<Profile> ListAll()
        {
            return profiles;
        }
        public Profile Get(int id)
        {
            Profile foundProfile = new Profile();
            foreach (Profile profile in profiles)
            {
                if (profile.Id == id)
                {
                    foundProfile = profile;
                }
            }
            return foundProfile;
        }
        public void Add(Profile profile)
        {
            if (profile == null)
            {
                return;
            }

            profiles.Add(profile);
        }

        public void AddDog(Profile profile, Hotdogs dog)
        {
            Profile p = Get(profile.Id);
            p.HotdogList.Add(dog);

        }
        public void Remove(Profile profile)
        {
            if (profile == null)
            {
                return;
            }

            Profile profileToRemove = null;
            foreach (Profile p in profiles)
            {
                if (p.Id == profile.Id)
                {
                    profileToRemove = p;
                }
            }
            if (profileToRemove != null)
            {
                profiles.Remove(profileToRemove);
            }
        }
        public void Update(Profile profile)
        {
            Profile profileToUpdate = Get(profile.Id);

            profileToUpdate.FirstName = profile.FirstName;
            profileToUpdate.LastName = profile.LastName;
            profileToUpdate.Bio = profile.Bio;
            profileToUpdate.ImageUrl = profile.ImageUrl;

            Remove(profile);
            Add(profileToUpdate);
        }
        public static void reload()
        {
            hotdogService = new HotdogsService();
            profiles = new List<Profile>();

            List<Hotdogs> myFavoriteHotdogs = new List<Hotdogs>();
            myFavoriteHotdogs.Add(hotdogService.Get(1));
            myFavoriteHotdogs.Add(hotdogService.Get(2));
            myFavoriteHotdogs.Add(hotdogService.Get(3));

            Profile p1 = new Profile()
            {
                Id = 1,
                FirstName = "Michael",
                LastName = "De Santa",
                Bio = "Vinewood movie producer.",
                ImageUrl = "http://25.media.tumblr.com/1a3712202d37b58884d9904cadfa7b7b/tumblr_mwxr75lYaV1sdpa88o3_250.png",
                FavoriteDog = hotdogService.Get(1),
                HotdogList = myFavoriteHotdogs
            };
            profiles.Add(p1);

            myFavoriteHotdogs = new List<Hotdogs>();
            myFavoriteHotdogs.Add(hotdogService.Get(1));
            myFavoriteHotdogs.Add(hotdogService.Get(3));

            Profile p2 = new Profile()
            {
                Id = 2,
                FirstName = "Franklin",
                LastName = "Clinton",
                Bio = "Owner of Los Santos Customs francise.",
                ImageUrl = "https://41.media.tumblr.com/f885da1f28f4247cdb27d64eed60e65a/tumblr_mwxr75lYaV1sdpa88o2_250.png",
                FavoriteDog = hotdogService.Get(2), //1
                HotdogList = myFavoriteHotdogs
            };
            profiles.Add(p2);

            myFavoriteHotdogs = new List<Hotdogs>();
            myFavoriteHotdogs.Add(hotdogService.Get(2));

            Profile p3 = new Profile()
            {
                Id = 3,
                FirstName = "Trevor",
                LastName = "Philips",
                Bio = "CEO of Trevor Phillips Industries",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/en/d/da/Trevor_Philips.Grand_Theft_Auto_V.jpg",
                FavoriteDog = hotdogService.Get(3),
                HotdogList = myFavoriteHotdogs
            };
            profiles.Add(p3);
        }
    }
    
}