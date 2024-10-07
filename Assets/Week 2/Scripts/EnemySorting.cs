using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySorting : MonoBehaviour
{
    public EnemyManager enemyManager;
    List<EnemyAbstract> sortEnemies = new();

    protected void Start()
    {
        //Invoke(nameof(this.Sorting), 2f);
    }

    // protected void Sorting()
    // {
    //     this.sortEnemies = new List<EnemyAbstract>(this.enemyManager.GetEnemies());

    //     this.PrintEnemyList(this.sortEnemies);
    //     this.sortEnemies.Sort((enemy1, enemy2) => enemy1.Health.CompareTo(enemy2.Health));
    //     this.PrintEnemyList(this.sortEnemies);
    // }

    public void SortEnemiesByHP()
    {
        this.sortEnemies = new List<EnemyAbstract>(this.enemyManager.GetEnemies());

        this.PrintEnemyList(this.sortEnemies);
        this.sortEnemies = enemies.OrderBy(enemy => enemy.HP).ToList();
        this.PrintEnemyList(this.sortEnemies);
    }
    void PrintEnemyList(List<EnemyAbstract> enemies)
    {
        Debug.Log("= Print ===================");

        foreach (var enemy in enemies)
        {
            Debug.Log(enemy.name + " - HP: " + enemy.Health);
        }
    }
}