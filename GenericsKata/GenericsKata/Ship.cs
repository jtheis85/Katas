using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsKata
{
  public class Ship
  {
    public Hardpoint<Shield> ShieldGenerator { get; set; }
    public Hardpoint<Weapon> FrontArc { get; set; }
    public Hardpoint<Weapon> RearArc { get; set; }
    public Hardpoint<Armor> FrontArmor { get; set; }
    public Hardpoint<Armor> PortArmor { get; set; }
    public Hardpoint<Armor> RearArmor { get; set; }
    public Hardpoint<Armor> StarboardArmor { get; set; }

    public Command<Captain,FirstOfficer> Staff { get; set; }
  }
}
