using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponDamage
{
    internal class WeaponDamage
    {
        private int roll;
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        
        public int Damage { get; protected set; }

        public WeaponDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }
        protected virtual void CalculateDamage()
        {
            /*Переопределяется субклассом*/
        }


        private bool magic;

        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }
        private bool flaming;

        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

    }
}
