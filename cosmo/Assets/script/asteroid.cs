using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    private float z;
    public float speed;
    public float n;
    public LayerMask whatIsSolid;
    public float distanse;
    public GameObject effect;
    public GameObject bonus;
    public float c;
    void Start()
    {
        z = Random.Range(0.1f, 0.5f);
        speed = Random.Range(1, 3);
        n= Random.Range(0.3f, 0.8f);
        c = Random.value;
    }

    void Update()
    {
        transform.Rotate(0f, 0f, z);
        transform.localScale=new Vector3(n, n, n);
        transform.Translate(Vector3.down* speed * Time.deltaTime, Space.World);
        Destroy(gameObject, 15);
        if (n < 0.3f)
        {
            Destroy(gameObject);
            global.score = global.score + 1;
            if (c >= 0.85f)
            {
                Instantiate(bonus, transform.position, Quaternion.identity);
            }

        }
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distanse, whatIsSolid);
        if (hitInfo.collider != null)
        {
            Destroy(gameObject);
            Destroy(hitInfo.collider.gameObject);
            Instantiate(effect, transform.position, Quaternion.identity);
            
        }
    }
    public void damage()
    {
        n = n - global.power;
    }
}
