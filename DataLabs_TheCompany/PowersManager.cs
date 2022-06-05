using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLabs_TheCompany
{
    public class PowersManager
    {
        private List<string> Power = new List<string>();
        private Dictionary<string, string> PowerDescription = new Dictionary<string, string>();

        private List<string> Vulnerability = new List<string>();
        private Dictionary<string, string> VulnerabilityDescription = new Dictionary<string, string>();

        public void AddPower(string name,string description = "Not yet filed")
        {
            Power.Add(name);
            PowerDescription.Add(name, description);
        }

        public void AddFlaw(string name,string description = "Not yet filed")
        {
            Vulnerability.Add(name);
            VulnerabilityDescription.Add(name, description);
        }

        public List<string> GetAllPowers()
        {
            return Power;
        }

        public List<string> GetAllFlaws()
        {
            return Vulnerability;
        }
    }
}
