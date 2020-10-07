using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    [SerializeField] public List<Attack> attacks = null;

    private Attack currentAttack = null;
    private int attackIndex = 0;

    private void Start()
    {
        if (attacks[attackIndex] == null) { return; }

        currentAttack = attacks[attackIndex];

        Debug.Log("current attack " + currentAttack.name);
    }

    private void Update()
    {
        
    }

    public Attack CurrentAttack()
    {
        return currentAttack;
    }

    public void SwitchToNextWeapon()
    {
        if (attackIndex + 1 >= attacks.Count)
        {
            attackIndex = 0;
            currentAttack = attacks[attackIndex];
            Debug.Log("Switched to " + currentAttack.name);
        }
        else
        {
            attackIndex++;
            currentAttack = attacks[attackIndex];
            Debug.Log("Switched to " + currentAttack.name);
        }
    }

    public void SwitchToPreviousWeapon()
    {
        if (attackIndex - 1 < 0)
        {
            attackIndex = attacks.Count - 1;
            currentAttack = attacks[attackIndex];
            Debug.Log("Switched to " + currentAttack.name);
        }
        else
        {
            attackIndex--;
            currentAttack = attacks[attackIndex];
            Debug.Log("Switched to " + currentAttack.name);
        }
    }

    public void AddAttack(Attack attackToAdd)
    {
        attacks.Add(attackToAdd);
    }

    public void RemoveAttack(Attack attackToRemove)
    {
        if (attacks.Count == 1) { return; }

        attacks.Remove(attackToRemove);
        SwitchToNextWeapon();
    }


}
