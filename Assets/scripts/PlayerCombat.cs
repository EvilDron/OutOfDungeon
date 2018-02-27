using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour {

    public float UntilNextAttack = 1.5f;

    private Animator anim;
    private float cooldown = 0f;
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (cooldown > 0) cooldown -= Time.deltaTime;
        if (cooldown < 0) cooldown = 0;

        if (Input.GetButtonDown("Fire1") && cooldown == 0)
        {
            anim.SetTrigger("Attack");
            cooldown = UntilNextAttack;
        }
	}
}
