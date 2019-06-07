using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAI : MonoBehaviour
{

    float wait = 0.0f;

    GameObject target;

    private unitStats UnitStats;
    private enemyStat stat;
    private placeUnit units;
    private Animator anim;
    private AudioManager audio;

    // Use this for initialization
    void Start()
    {
        units = Camera.main.GetComponent<placeUnit>();
        anim = GetComponent<Animator>();
        UnitStats = GetComponent<unitStats>();
        audio = FindObjectOfType<AudioManager>().GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (units.fight == true)
        {
            target = FindEnemy();
            float distance = Vector3.Distance(transform.position, target.transform.position);
            if (UnitStats.health > 0)
            {
                if (distance > UnitStats.range)
                {
                    transform.position = Vector2.MoveTowards(transform.position, target.transform.position, UnitStats.speed * Time.deltaTime);
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
    }

    GameObject FindEnemy()
    {
        GameObject[] enemy;
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject Enemy in enemy)
        {
            Vector3 diff = Enemy.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = Enemy;
                distance = curDistance;
            }
        }
        return closest;
    }

    void Attack(GameObject target)
    {
        if (audio.isFighting == false)
        {
            audio.isFighting = true;
            FindObjectOfType<AudioManager>().Stop("yelling");
            FindObjectOfType<AudioManager>().Play("BattleSounds");
        }
        stat = target.GetComponent<enemyStat>();
        if (target)
        {
            if (Time.time > wait)
            {
                wait = Time.time + UnitStats.attRate;
                int att = Random.Range(0, 20);
                if (att >= stat.armor)
                {
                    stat.health -= UnitStats.damage;
                }
            }
            //Debug.Log("Attacking");
        }
    }
}