using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy5Shot : MonoBehaviour
{
    [SerializeField] private GameObject enemyshotR;
    [SerializeField] private GameObject enemyshotL;
    [SerializeField] private GameObject enemyshotU;
    [SerializeField] private GameObject enemyshotD;
    GameObject enemy5;
    private float span = 3.0f;
    private float time = 0f;
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
        time += Time.deltaTime;
        if (time > span)
        {
            Instantiate(enemyshotR);
            Instantiate(enemyshotL);
            Instantiate(enemyshotU);
            Instantiate(enemyshotD);
            enemyshotR.transform.position = new Vector2(x, y);
            enemyshotL.transform.position = new Vector2(x, y);
            enemyshotU.transform.position = new Vector2(x, y);
            enemyshotD.transform.position = new Vector2(x, y);
            time = 0f;
        }
    }
}