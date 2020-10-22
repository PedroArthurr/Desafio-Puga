using UnityEngine;
using System.Collections.Generic;

public class Status : MonoBehaviour
{

    [Header("Settings")]
    [HideInInspector] public ShipType myType;
    [HideInInspector] public List<StatusLevel> allStatus;
    [HideInInspector] public int healthLevel;
    [HideInInspector] public int attackLevel;
    [HideInInspector] public int speedLevel;

    [Header("Behaviour")]
    protected int damage;
    protected int currentLife;


    public void TakeDamage(float applyDamage)
    {
        allStatus[healthLevel - 1].health -= (int)applyDamage;
    }


    public void Death(float dropTax = 0, GameObject ob = null)
    {
        Destroy(this.gameObject);

        if (myType == ShipType.ENEMY)
        {
            int chance = Random.Range(0, 101);
            if (chance >= 100 - (int)(dropTax * 100))
            {
                Instantiate(ob, transform.position, Quaternion.identity);
            }
        }
    }
}

[System.Serializable]
public class StatusLevel 
{
    public int health;
    public int attack;
    public float speed;
}