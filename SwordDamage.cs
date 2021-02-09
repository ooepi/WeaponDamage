using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WeaponDamageCalculator
{
    class SwordDamage : WeaponDamage
    {
        public SwordDamage(int startingRoll) : base(startingRoll){}

        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;


        protected override void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;

        }
    }
}
