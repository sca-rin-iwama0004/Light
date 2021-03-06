using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy5ShotR : MonoBehaviour
{
    private float speed = 0.005f;
    GameObject enemy5;
    // Start is called before the first frame update
    void Start()
    {
        enemy5 = GameObject.Find("Enemy5");
    }

    // Update is called once per frame
    void Update()
    {
        float x = enemy5.transform.position.x;
        float y = enemy5.transform.position.y;
        transform.position += new Vector3(speed, 0.0f, 0.0f);
        if(this.transform.position.x >= x +7.0f)
        {
            this.gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
        }
    }
}