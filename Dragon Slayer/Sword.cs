﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Slayer
{
    class Sword : Item
    {
        //Private fields
        private int _level;
        private int _attackValue;
        private int _goldValue;


        //Public fields
        public int level
        {
            get
            {
                return _level;
            }
            set
            {
                if (value < 0)
                {
                    _level = 0;
                }
                else if (value > 4)
                {
                    _level = 4;
                }
                else
                {
                    _level = value;
                }
            }
        }
        public int attackValue
        {
            get
            {
                return _attackValue;
            }
            set
            {
                if (level == 0)
                {
                    _attackValue = 0;
                }
                else if (level == 1)
                {
                    _attackValue = 10;
                }
                else if (level == 2)
                {
                    _attackValue = 30;
                }
                else if (level == 3)
                {
                    _attackValue = 70;
                }
                else if (level == 4)
                {
                    _attackValue = 150;
                }
            }
        }
        new public int goldValue
        {
            get
            {
                return _goldValue;
            }
            set
            {
                if (level == 0)
                {
                    _goldValue = 200;
                }
                else if (level == 1)
                {
                    _goldValue = 1000;
                }
                else if (level == 2)
                {
                    _goldValue = 2500;
                }
                else if (level == 3)
                {
                    _goldValue = 10000;
                }
            }
        }


        //Constructor
        public Sword(int _level, int _attackValue, int _ID, string _name, int _goldValue, string _description) :
            base(_ID, _name, _goldValue, 1, _description)
        {
            level = _level;
            attackValue = _attackValue;
            goldValue = 1;
        }


        //Display sword level
        public void DisplaySword(Sword _sword)
        {
            if (_sword.level == 0)
            {
                Console.WriteLine("Sword Level: ░ ░ ░ ░");
            }
            else if (_sword.level == 1)
            {
                Console.WriteLine("Sword Level: █ ░ ░ ░");
            }
            else if (_sword.level == 2)
            {
                Console.WriteLine("Sword Level: █ █ ░ ░");
            }
            else if (_sword.level == 3)
            {
                Console.WriteLine("Sword Level: █ █ █ ░");
            }
            else if (_sword.level == 4)
            {
                Console.WriteLine("Sword Level: █ █ █ █");
            }
        }


        //Upgrade the swords level
        public void Upgrade(Player _player, Sword _sword)
        {
            _sword.level++;
            _sword.attackValue++;
            _sword.goldValue++;
            _player.attack += 0;
        }
    }
}
