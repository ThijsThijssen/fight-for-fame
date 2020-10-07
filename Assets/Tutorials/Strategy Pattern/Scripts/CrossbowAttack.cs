using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Attacks/Crossbow Attack")]
public class CrossbowAttack : Attack
{
    public int Damage = 5;
    public float Range = 20f;
    public int Arrows = 1;

    public override void Execute(Player player, EnemyManager enemyManager)
    {
        Debug.Log(name + " did " + Damage + " damage!");
    }
}
