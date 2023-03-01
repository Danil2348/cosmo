using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public GameObject bullet;
    public Transform shotPoint;
    public float x;
    private bool b=true;
    void Start()
    {
    }
    void move()
    {
        Instantiate(bullet, shotPoint.position, shotPoint.rotation);
        b = true;
    }
    void Update()
    {
        if (b == true)
        {
            Invoke("move", x);
            b = false;
        }
        
    }

}
