using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public int damage = 1;
    public int criticalDamage = 2;

    bool canDamage = false;
	void Start () {
		
	}
	
    public void CanDamage()
    {
        canDamage = true;
    }
    public void Damage(Enemy enemy, int damage)
    {
        enemy.GetDamage(damage);
    }
    private void OnTriggerStay(Collider other)
    {
        if(canDamage && other.tag == "Enemy")
        {
            Damage(other.GetComponent<Enemy>(), damage);
        }
    }

}
