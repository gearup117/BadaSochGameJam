using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    public AudioSource[] audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            Debug.Log("audio");
            if (!audioSource[0].isPlaying)
            {

                audioSource[0].Play();
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (!audioSource[1].isPlaying)
                {
                    audioSource[0].Pause();
                    audioSource[1].Play();
                }
            }
        }
        else {
            audioSource[0].Pause();
            audioSource[1].Pause();
        }
        
    }
}
