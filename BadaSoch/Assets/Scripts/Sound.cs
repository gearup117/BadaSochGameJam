using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    //public AudioSource audioSource;
    
    
    // Start is called before the first frame update
    private void Awake()
    {
        //audioListener = player.GetComponent<AudioListener>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(audioListener.enabled);
    }
    public void toggleSound() {
        if (AudioListener.volume == 1f)
        {
            AudioListener.volume = 0f;
        }
        else {
            AudioListener.volume = 1f;
        }
        
    }
}
