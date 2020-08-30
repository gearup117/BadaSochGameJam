using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int health,maxHealth;
    public TextMeshProUGUI healthText,maxHealthText;
    Animator anim;
    // Start is called before the first frame update
    private void Awake()
    {
        health = maxHealth;
    }
    void Start()
    {
        
        anim = gameObject.GetComponentInChildren<Animator>();
        
        InvokeRepeating("decreaseHealth", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > maxHealth) {
            health = maxHealth;
        }
    }
    void decreaseHealth()
    {
        if (health > 0)
        {
            maxHealthText.text = maxHealth.ToString();

            if (anim.GetBool("run") && health > 0)
            {
                health -= 3;

            }
            else if (health < maxHealth)
            {
                health++;


            }
            healthText.text = health.ToString();
        }
        else
        //Player Dies
        {
            maxHealthText.text = "0";
            healthText.text = "0";
            anim.SetBool("run", false);
            anim.SetTrigger("Die");
            
        }
        
    }
    
}
