using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGWizard1.Data.Models
{
    public class SubRace
    {
        public int ID { get; set; }
        public int Race_ID { get; set; }
        public string SubRaceName { get; set; }
        public int  Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Wisdom { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        public string Size { get; set; }
        public int Speed { get; set; }
        public string Vision { get; set; }
        public string Resistances { get; set; }
        public string Proficiencies { get; set; }
        public string Languages { get; set; }
        public string Special { get; set; }

    }
}
