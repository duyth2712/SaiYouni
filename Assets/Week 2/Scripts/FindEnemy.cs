using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FindEnemy : MonoBehaviour
{
    //----------------------Edit below here --------------------
    public Enemy FindEnemyWithSmallestHealth(Enemy[] enemies)
    {
        if (enemies == null || enemies.Length == 0) return null;

        return enemies.OrderBy(enemy => enemy.HP).FirstOrDefault();
    }

    public Enemy FindEnemyWithLargestHealth(Enemy[] enemies)
    {
        if (enemies == null || enemies.Length == 0) return null;

        return enemies.OrderByDescending(enemy => enemy.HP).FirstOrDefault();
    }

    //----------------------Edit above here --------------------
}
