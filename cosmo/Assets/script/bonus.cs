using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonus : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distanse;
    public LayerMask whatIsSolid;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        Destroy(gameObject, 5);
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distanse, whatIsSolid);
        if (hitInfo.collider != null)
        {
            global.v += 1;
            Destroy(gameObject);
        }
    }
}
