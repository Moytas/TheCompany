using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLabs_TheCompany
{

    public enum Gender
    {
        male,
        female,
        nogender
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Gender myGender;

        public Dictionary<string, Gender> GenderRelation = new Dictionary<string, Gender>();
        List<Dictionary<string, string>> dictionaryList = new List<Dictionary<string, string>>();
        public void ChangeGender()
        {
            GenderRelation.Add("Alex", Gender.male);
            Dictionary<string, string> blah = new Dictionary<string, string>();
            dictionaryList.Add(blah);
            
            dictionaryList[0].TryGetValue("blah", out string test);
            //Gender test;
            //GenderRelation.TryGetValue("Alex", out test);
            //GenderRelation.TryGetValue("Maria", out test);
            if(myGender == 0)
            {
                myGender = Gender.female;
            }
            else
            {
                myGender = Gender.male;
            }
        }
            
    }
}
