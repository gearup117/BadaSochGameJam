using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAttack : MonoBehaviour
{
    public int damage;
    GameObject player;
    Vector2 enemyPosi;
    float distanceBetween;
    NavMeshAgent navMesh;
    Animator anim;
    //public NavMesh navMesh;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        navMesh = gameObject.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        enemyPosi = new Vector2(transform.position.x, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        distanceBetween = (Vector3.Distance(transform.position, player.transform.position));
        if (distanceBetween <= navMesh.stoppingDistance)
        {
            anim.SetBool("Attack", true);
            navMesh.speed = 0;
            

        }
        else {
           // anim.SetBool("Attack", false);
        }

    }
    //Decrease the health after waiting for some time
   public void attack() {
        
        var pl = player.GetComponent<PlayerStats>();
        pl.maxHealth -= damage;
        pl.health = pl.maxHealth;
        anim.SetBool("Attack", false);
    }
}
