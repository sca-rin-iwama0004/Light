﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    GameObject player;
    PlayerControl script;
    int dir;
    float moveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        script = player.GetComponent<PlayerControl>();
        dir = script.Direction;
        moveSpeed = script.GunSpeed;

    }

    // Update is called once per frame
    void Update()
    {


        if (dir == 1)
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }
        else if (dir == 2)
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
        else if (dir == 3)
        {
            transform.Translate(0,moveSpeed * Time.deltaTime, 0);
        }
        else if (dir == 4)
        {
            transform.Translate(0,-moveSpeed * Time.deltaTime, 0);

        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Player" && other.gameObject.tag != "Partner")
        {
            Destroy(gameObject);
        }

    }
}

//10