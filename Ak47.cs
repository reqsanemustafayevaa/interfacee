using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceee
{
    public class Ak47 : Gun,Iweapon
    {

        public void Makedamage()
        {
            Console.WriteLine("20dmg");
        }

        public override void Shoot()
        {
            Console.WriteLine("pav pav");
        }
    }
}
