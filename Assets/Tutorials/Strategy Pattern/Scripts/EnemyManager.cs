using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<GameObject> enemies;

    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy").ToList();
    }

    void Update()
    {
        
    }

    public List<GameObject> GetEnemies()
    {
        return enemies;
    }

    public void RemoveEnemy(GameObject enemy)
    {
        List<GameObject> newEnemies = enemies.ToList();
        newEnemies.Remove(enemy);
        enemies = newEnemies;
    }
}
