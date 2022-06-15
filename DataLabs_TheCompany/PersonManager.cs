using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLabs_TheCompany
{
    public class PersonManager
    {
        public List<Person> PeopleList = new List<Person>();
        private List<Supers> TargetList = new List<Supers>();

        public void Add(Person _person)
        {
            PeopleList.Add(_person);
        }

        public void Add(Supers _super)
        {
            TargetList.Add(_super);
        }

    }
}
