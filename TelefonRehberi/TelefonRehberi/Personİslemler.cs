using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public class Personİslemler
    {

        public int personSearch(List<Person> rehber, string arama)
        {
            int deletedId = -1;
            foreach (var item in rehber)
            {
                if (item.FirstName == arama || item.LastName == arama)
                {
                    deletedId = rehber.IndexOf(item);
                    break;
                }
                else
                {
                    deletedId = -1;
                }
            }
            return deletedId;
        }
        public int personTelefonNumberSearch(List<Person> rehber, string phoneNumber)
        {
            int phoneIndex = -1;
            foreach (var item in rehber)
            {
                if (item.Phone == phoneNumber)
                {
                    phoneIndex = rehber.IndexOf(item);
                    break;
                }
                else
                {
                    phoneIndex = -1;
                }
            }
            return phoneIndex;
        }

    }
}
