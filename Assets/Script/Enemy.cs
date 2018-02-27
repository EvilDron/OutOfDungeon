using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int health = 100; 
    public void GetDamage(int damage)
    {
        health -= damage;
    }
}
