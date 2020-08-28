using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    string type;
   public  GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        type = gameObject.tag;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(gameObject.transform.position, player.transform.position) <= 1) {
            if (type == "Health") {
                var a = player.GetComponent<PlayerStats>();
                a.health = 100;
                a.maxHealth = 100;
                Destroy(gameObject);
            }
            if (type == "BulletReset") {
                Debug.Log("Bullet");
                var a = player.GetComponentInChildren<Gun>();
                a.bulletNo = 30;
                a.totalBullet = 120;
                Destroy(gameObject);
            }
        }
    }
}
