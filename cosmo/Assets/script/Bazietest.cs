using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bazietest : MonoBehaviour
{
    public GameObject[] c;
    public float speed;
    public float p=0.1f;
    public void Start()
    {
        c= GameObject.FindGameObjectsWithTag("point1");
    }

    public void Update()
    {
        transform.position = Vector3.MoveTowards(c[0].transform.position, c[1].transform.position, p);
        p += speed * Time.deltaTime;
        if (transform.position == c[1].transform.position)
        {
            transform.position = c[0].transform.position;
            p = 0.1f;
        }
    }

}





