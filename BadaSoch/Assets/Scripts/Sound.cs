using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject player;
    private AudioListener audioListener;
    // Start is called before the first frame update
    void Start()
    {
        audioListener = player.GetComponent<AudioListener>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void toggleSound() {
        //if (!audioSource.mute)
        //{
        //    audioSource.mute = true;
        //}
        //else {
        //    audioSource.mute = false;
        //}
        Debug.Log(audioListener.enabled);
        if (!audioListener.enabled)
        {
            audioListener.enabled = true;
        }
        else {
            audioListener.enabled = false;
        }
    }
}
