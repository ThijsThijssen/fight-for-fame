using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attack : ScriptableObject, IAttack
{
    public abstract void Execute(Player player, EnemyManager enemyManager);
}
