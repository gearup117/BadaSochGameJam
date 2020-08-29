﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Animator anim;
    public Transform player;
    public float height;
    public float smooth;
     Vector3 velocity = Vector3.zero;
    private Gun gun;
    // Start is called before the first frame update
    void Start()
    {
        gun = player.GetComponentInChildren<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3();
        pos.x = player.position.x;
        pos.y = player.position.y + height;
        pos.z = player.position.z - 10f;
        transform.position = Vector3.SmoothDamp(transform.position, pos, ref velocity, smooth);
        if (gun.anim.GetBool("shoot"))
        {
            anim.SetBool("Shake", true);
        }
        else {
            anim.SetBool("Shake", false);
        }
    }
}
