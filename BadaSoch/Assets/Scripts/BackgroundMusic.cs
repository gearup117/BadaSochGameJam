using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void change()
    {
        audioSource.Pause();
        Debug.Log("change");
        audioSource.clip = audioClip;
        audioSource.Pause();
        audioSource.Play();
    }
}
