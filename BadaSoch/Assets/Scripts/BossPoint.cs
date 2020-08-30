using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossPoint : MonoBehaviour
{
    public GameObject healthBar;
    public LayerMask playerMask;
    bool sawPlayer;
   public float radius;
    public GameObject bossBarricade;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sawPlayer = Physics.CheckSphere(transform.position, radius, playerMask);
        if (sawPlayer) {
            bossBarricade.SetActive(true);
            healthBar.SetActive(true);
        }
    }
    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
        
    }
}
