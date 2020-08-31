using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClip;
    public Animator anim;
    bool running,shooting;

    // Start is called before the first frame update
    private void Awake()
    {
        //audioSource.clip = audioClip[3];
    }
    void Start()
    {
        playSound();
    }

   
    // Update is called once per frame
    void Update()
    {
        if (!anim.GetBool("shoot"))
        {
            run();
        }
       shoot();
        playSound();
       

    }
    void run() {
        //Walk
        //if ((anim.GetFloat("vertical") != 0 || anim.GetFloat("horizontal") != 0))
        //{

        //    running = true;

        //    audioSource.clip = audioClip[0];

        //    if (!audioSource.isPlaying)
        //    {
        //        audioSource.Play();
        //    }


        //}
        //else if(!shooting)
        //{
        //    running = false;
        //    audioSource.Pause();
        //}
        //////Run
        //if (anim.GetBool("run"))
        //{
        //    running = true;
        //    audioSource.clip = audioClip[1];


        //    if (!audioSource.isPlaying)
        //    {
        //        audioSource.Play();
        //    }
        //}
        //else if ((anim.GetFloat("vertical") == 0 && anim.GetFloat("horizontal") == 0) && !shooting)
        //{
        //    running = false;
        //    audioSource.Pause();

        //}
        if ((anim.GetFloat("vertical") != 0 || anim.GetFloat("horizontal") != 0))
        {
            
            audioSource.clip = audioClip[0];
            
        }
        else if (anim.GetBool("run"))
        {
            
            audioSource.clip = audioClip[1];
            
        }
        else {
            
            audioSource.clip = audioClip[3];
            
        }
    }
    void shoot() {
        if (anim.GetBool("shoot"))
        {
            
            audioSource.clip = audioClip[2];
            

        }
        else{
            //audioSource.clip = audioClip[3];
            
        }
    }
    void playSound()
    {
        
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
