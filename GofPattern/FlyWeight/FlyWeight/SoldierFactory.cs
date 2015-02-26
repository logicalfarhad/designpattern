using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlyWeight.FlyWeight;

namespace FlyWeight.FlyWeight
{
    public class SoldierFactory
    {
        private static readonly Dictionary<Enum, ISoldier> SoldierContainer = new Dictionary<Enum, ISoldier>();
        public static ISoldier GetSoldier(SoldierType soldierType)
        {
            ISoldier soldier = null;

            if (SoldierType.ASUR == soldierType)
            {
                if (!SoldierContainer.ContainsKey(soldierType))
                {
                    soldier = new Asur(100);
                    SoldierContainer.Add(soldierType, soldier);
                }
                soldier = SoldierContainer[soldierType];
            }
            else if (SoldierType.SONNASI == soldierType)
            {
                if (!SoldierContainer.ContainsKey(soldierType))
                {
                    soldier = new Sonnasi(200);
                    SoldierContainer.Add(soldierType, soldier);
                }
                soldier = SoldierContainer[soldierType];
            }
            return soldier;
        }
    }
}
