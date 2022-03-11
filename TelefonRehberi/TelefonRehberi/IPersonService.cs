using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    interface IPersonService
    {
        void Add(List<Person> rehber);
        void Update(List<Person> rehber);
        void Delete(List<Person> person);
        void ListAll(List<Person> persons);
        void ListPerson(List<Person> persons);
    }
}
