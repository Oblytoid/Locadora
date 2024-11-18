using Locadora.src.model;
using Locadora.src.services;
using System.Collections.Generic;

namespace Locadora.src.controller
{
    public class GenderController
    {
        private static GenderRepository genderRepository = new GenderRepository();

        public static void RegisterGender(GenderItem gender)
        {
            if (string.IsNullOrWhiteSpace(gender.Name))
            {
                
            }

            genderRepository.SaveGender(gender);
            
        }

        public static GenderItem GetGender(int id)
        {
            return genderRepository.GetGenderById(id);
        }

        public static List<GenderItem> GetAllGenders()
        {
            return genderRepository.GetAllGenders();
        }

        public static bool UpdateGender(GenderItem gender)
        {
            if (string.IsNullOrWhiteSpace(gender.Name))
            {
                return false;
            }

            genderRepository.UpdateGender(gender);
            return true;
        }

        public static bool DeleteGender(int id)
        {
            genderRepository.DeleteGender(id);
            return true;
        }
    }
}
