using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCamera : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCamera;
    public GameObject goalText,zombies;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("begin", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void begin() {
        player.SetActive(true);
        mainCamera.SetActive(true);
        goalText.SetActive(false);
        zombies.SetActive(true);
        Destroy(gameObject);

    }
}
