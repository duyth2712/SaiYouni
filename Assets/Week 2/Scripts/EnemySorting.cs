using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EnemySorting : MonoBehaviour
{
    public EnemyManager enemyManager;
    List<EnemyAbstract> sortEnemies = new();

    protected void Start()
    {
        this.SortEnemiesByHP();
    }

    // protected void Sorting()
    // {
    //     this.sortEnemies = new List<EnemyAbstractOld>(this.enemyManager.GetEnemies());

    //     this.PrintEnemyList(this.sortEnemies);
    //     //this.SelectionSort(this.sortEnemies);
    //     this.sortEnemies.Sort((enemy1, enemy2) => enemy1.Health.CompareTo(enemy2.Health));
    //     this.PrintEnemyList(this.sortEnemies);
    // }
    protected void SortEnemiesByHP()
    {
        this.sortEnemies = new List<EnemyAbstract>(this.enemyManager.GetEnemies());
        this.PrintEnemyList(this.sortEnemies);
        sortEnemies =  enemies.OrderBy(enemy => enemy.HP).ToList();
        this.PrintEnemyList(this.sortEnemies);
    }
    void PrintEnemyList(List<EnemyAbstract> enemies)
    {
        Debug.Log("=========== Print ============");

        foreach (var enemy in enemies)
        {
            Debug.Log(enemy.name + " - HP: " + enemy.Health);
        }
    }
}