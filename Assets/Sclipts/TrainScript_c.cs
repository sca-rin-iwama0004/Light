using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainScript_c : MonoBehaviour
{
    public GameObject[] Train;
    private int randomNumber;
    public int c;
    public int number;

    void Start()
    {
        number = Random.Range(0, Train.Length);
        Instantiate(Train[number], transform.position, transform.rotation);
    }

    public int GetNumberC()
    {
        if (number == 0)
        {
            c = 0;
            Debug.Log("c=" + c);
        }
        else if (number == 1)
        {
            c = 1;
            Debug.Log("c=" + c);
        }
        else if (number == 2)
        {
            c = 2;
            Debug.Log("c=" + c);
        }
        else if (number == 3)
        {
            c = 3;
            Debug.Log("c=" + c);
        }
        else if (number == 4)
        {
            c = 4;
            Debug.Log("c=" + c);
        }
        else if (number == 5)
        {
            c = 5;
            Debug.Log("c=" + c);
        }
        else if (number == 6)
        {
            c = 6;
            Debug.Log("c=" + c);
        }
        else if (number == 7)
        {
            c = 7;
            Debug.Log("c=" + c);
        }
        else if (number == 8)
        {
            c = 8;
            Debug.Log("c=" + c);
        }
        else if (number == 9)
        {
            c = 9;
            Debug.Log("c=" + c);
        }

        return c;

    }
}
