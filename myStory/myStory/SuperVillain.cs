using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperVillain : SuperHuman
    {
        public string _evilLaugh;
        public int _attack;

        public SuperVillain(string evilLaugh, int  attack, string name, int healthPoints) : base(name, healthPoints)
        {
            _evilLaugh = evilLaugh;
            _attack = attack;
            _healthPoints = healthPoints;
            _name = name;
        }

    }
}
