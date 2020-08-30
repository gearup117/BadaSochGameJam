using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public Image healthBar;
    public float health;
    public LayerMask playerMask;
    public float viewRadius,attackRadius;
    bool sawPlayer,attackPlayer,chaseAgain,attackAgain;
     Animator anim;
    NavMeshAgent navMesh;
    public GameObject player;
    float speed;
    public Barricade[] barricade;
    // Start is called before the first frame update
    void Start()
    {
        health = 0.1f;
        chaseAgain = true;
        attackAgain = true;
        anim = gameObject.GetComponent<Animator>();
        navMesh = gameObject.GetComponent<NavMeshAgent>();
        speed = navMesh.speed;
    }

    // Update is called once per frame
    void Update()
    {
        
            viewCone();
            attack();
        healthBar.fillAmount = health;
        death();

    }
    public void death() {
        if (health <= 0) {
            barricade[0].enabled = true;
            barricade[1].enabled = true;
            chaseAgain = false;
            attackAgain = false;
            anim.SetTrigger("Die");
            Invoke("destroy", 2f);
        }

   }
    public void destroy()
    {
        Destroy(gameObject);
    }
    public void attack() {
        if (attackAgain)
        {
            attackPlayer = Physics.CheckSphere(transform.position, attackRadius, playerMask);


            if (attackPlayer)
            {
                anim.SetBool("Run", false);
                //anim.SetBool("Attack", true);
                anim.SetTrigger("Attack");
                navMesh.speed = 0f;
                chaseAgain = false;
                attackAgain = false;
                Invoke("waitToRun", 3f);
            }
        }
       
    }
    public void damagePlayer() {
        player.GetComponent<PlayerStats>().maxHealth -= 5;
        
    }
    void waitToRun() {

        chaseAgain = true;
        attackAgain = true;
        navMesh.speed = speed;
        
    }
    public void run() {
        anim.SetBool("Run", true);
        navMesh.SetDestination(player.transform.position);

    }
    public void viewCone() {
            sawPlayer = Physics.CheckSphere(transform.position, viewRadius, playerMask);
            if (sawPlayer && chaseAgain)
            {
            viewRadius = 100f;
                run();
            }
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet") {
            health -= 0.01f;
        }
    }
    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, viewRadius);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }
}
