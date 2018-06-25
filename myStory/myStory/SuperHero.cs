using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperHero : SuperHuman 
    {
        public string _nickName;
        public string _power;

        public SuperHero(string nickname, string power, string name, int healthPoints) : base(name, healthPoints)
        {
            _nickName = nickname;
            _power = power;
            _healthPoints = healthPoints;
            _name = name;
        }
    }
}
