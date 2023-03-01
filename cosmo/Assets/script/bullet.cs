using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distanse;
    public LayerMask whatIsSolid;
    public GameObject effect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        Destroy(gameObject, 5);
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distanse, whatIsSolid);
        if (hitInfo.collider!=null)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            hitInfo.collider.GetComponent<asteroid>().damage();
            Destroy(gameObject);
        }
    }

}
