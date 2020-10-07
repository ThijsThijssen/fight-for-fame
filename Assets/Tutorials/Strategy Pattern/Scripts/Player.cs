using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    private WeaponHandler weaponHandler;
    private EnemyManager enemyManager;

    [SerializeField] public Attack attackToPickup = null;

    private void Start()
    {
        weaponHandler = gameObject.GetComponent<WeaponHandler>();
        enemyManager = FindObjectOfType<EnemyManager>();
    }

    public void Attack(IAttack attack)
    {
        attack.Execute(this, enemyManager);
    }

    private void Update()
    {
        if (weaponHandler == null) { return; }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Attack(weaponHandler.CurrentAttack());
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            SwitchToNextWeapon();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SwitchToPreviousWeapon();
        }

        if (attackToPickup == null) { return; }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            weaponHandler.AddAttack(attackToPickup);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            weaponHandler.RemoveAttack(weaponHandler.CurrentAttack());
        }
    }

    private void SwitchToNextWeapon()
    {
        weaponHandler.SwitchToNextWeapon();
    }

    private void SwitchToPreviousWeapon()
    {
        weaponHandler.SwitchToPreviousWeapon();
    }
}
