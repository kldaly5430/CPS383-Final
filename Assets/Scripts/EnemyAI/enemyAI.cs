using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour {

    float wait = 0.0f;

    GameObject target;

    private enemyStat stat;
    private unitStats UnitStats;
    private Animator anim;
    private placeUnit units;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        stat = GetComponent<enemyStat>();
        units = Camera.main.GetComponent<placeUnit>();
        anim.SetBool("isStanding", true);
    }
	
	// Update is called once per frame
	void Update () {
        
		if(units.fight == true)
        {
            target = FindEnemy();
            float distance = Vector3.Distance(transform.position, target.transform.position);
            if (stat.health > 0)
            {
                if (distance > stat.range)
                {
                    transform.position = Vector2.MoveTowards(transform.position, target.transform.position, stat.speed * Time.deltaTime);
                    anim.SetBool("isStanding", false);
                    anim.SetBool("isWalking", true);
                    anim.SetBool("isAttacking", false);
                }
                else
                {
                    anim.SetBool("isAttacking", true);
                    anim.SetBool("isWalking", false);
                    Attack(target);
                }
            }
            else
            {
                anim.SetBool("isStanding", false);
                anim.SetBool("isWalking", false);
                anim.SetBool("isAttacking", false);
                anim.SetBool("isDead", true);
                if (anim.GetCurrentAnimatorStateInfo(0).IsName("isDead"))
                    DestroyObject(this);
            }
        }
        else
        {
            anim.SetBool("isStanding", true);
        }
	}

    GameObject FindEnemy()
    {
        GameObject[] enemy;
        enemy = GameObject.FindGameObjectsWithTag("Player");

        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach(GameObject Enemy in enemy)
        {
            Vector3 diff = Enemy.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if(curDistance < distance)
            {
                closest = Enemy;
                distance = curDistance;
            }
        }
        return closest;
    }

    void Attack(GameObject target)
    {
        UnitStats = target.GetComponent<unitStats>();
        if(target)
        {
            if(Time.time > wait)
            {
                wait = Time.time + stat.attRate;
                int att = Random.Range(0, 20);
                if (att >= UnitStats.armor)
                    UnitStats.health -= stat.damage;
            }
        }
    }
}
