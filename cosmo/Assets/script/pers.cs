using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class pers : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    private Vector3 _input;
    [SerializeField] private float _speed;
    private Vector2 min;
    private Vector2 max;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject bullet;
    void Start()
    {
        min = Camera.main.ViewportToWorldPoint(new Vector2(0, -0.2f));
        max = Camera.main.ViewportToWorldPoint(new Vector2(1.04f, 0.66f));
    }

    void Update()
    {
        _input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.position += _input * _speed * Time.deltaTime;
        if (transform.position.x > max.x)
        {
            transform.position = new Vector2(max.x, transform.position.y);
        }
        if(transform.position.x < min.x)
        {
            transform.position = new Vector2(min.x, transform.position.y);
        }
        if (transform.position.y > max.y)
        {
            transform.position = new Vector2(transform.position.x, max.y);
        }
        if (transform.position.y < min.y)
        {
            transform.position = new Vector2(transform.position.x, min.y);
        }
        if (p1 != null)
        {
            if (global.v == 0)
            {
                p1.GetComponent<shot>().enabled = true;
                bullet.GetComponent<Transform>().localScale = new Vector3(0.04f, 0.04f, 0.04f);
                global.power = 0.05f;
            }
            if (global.v == 1)
            {
                p1.GetComponent<shot>().enabled = false;
                p2.GetComponent<shot>().enabled = true;
                p3.GetComponent<shot>().enabled = true;
                bullet.GetComponent<Transform>().localScale = new Vector3(0.04f, 0.04f, 0.04f);
                global.power = 0.05f;
            }
            if (global.v == 2)
            {
                p1.GetComponent<shot>().enabled = true;
                p2.GetComponent<shot>().enabled = true;
                p3.GetComponent<shot>().enabled = true;
                bullet.GetComponent<Transform>().localScale = new Vector3(0.04f, 0.04f, 0.04f);
                global.power = 0.05f;
            }
            if (global.v == 3)
            {
                p1.GetComponent<shot>().enabled = true;
                bullet.GetComponent<Transform>().localScale = new Vector3(0.08f, 0.08f, 0.08f);
                global.power = 0.1f;
                p2.GetComponent<shot>().enabled = false;
                p3.GetComponent<shot>().enabled = false;

            }
            if (global.v == 4)
            {
                p1.GetComponent<shot>().enabled = false;
                bullet.GetComponent<Transform>().localScale = new Vector3(0.08f, 0.08f, 0.08f);
                global.power = 0.1f;
                p2.GetComponent<shot>().enabled = true;
                p3.GetComponent<shot>().enabled = true;

            }
            if (global.v == 5)
            {
                p1.GetComponent<shot>().enabled = true;
                bullet.GetComponent<Transform>().localScale = new Vector3(0.08f, 0.08f, 0.08f);
                global.power = 0.1f;
                p2.GetComponent<shot>().enabled = true;
                p3.GetComponent<shot>().enabled = true;

            }
        }
        

    }

    public void OnBeginDrag(PointerEventData touch)
    {
        _input = transform.position - (Vector3)touch.position;
        _input.z = 0.0f;

    }
    public void OnDrag(PointerEventData touch)
    {
        var b = (Vector3)touch.position;
        b.z = 0.0f;
        transform.position = b + _input;
    }
}
