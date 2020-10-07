using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Attacks/Melee Attack")]
public class MeleeAttack : Attack
{
    public int damage = 1;

    public MeleeAttack(string name)
    {
        this.name = name;
    }

    public override void Execute(Player player, EnemyManager enemyManager)
    {
        foreach (GameObject enemy in enemyManager.GetEnemies())
        {
            if (Vector3.Distance(player.transform.position, enemy.transform.position) < 5f)
            {
                Debug.Log(enemy.name + " is in range");
                enemy.GetComponent<Health>().TakeDamage(damage);
            }
        }
        Debug.Log(name + " did " + damage + " damage!");
    }
}
