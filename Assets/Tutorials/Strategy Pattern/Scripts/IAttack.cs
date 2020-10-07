using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttack
{
    void Execute(Player player, EnemyManager enemyManager);
}
