using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Barricade : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(Vector3.Distance(gameObject.transform.position, player.transform.position));
        if (Vector3.Distance(this.gameObject.transform.position, player.transform.position) < 5) {
            SceneManager.LoadScene("GameCompleted");
        }
    }
    
}
