using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cosmo : MonoBehaviour
{
    public LayerMask whatIsSolid1;
    public GameObject[] cosm;
    public float distanse;
    public GameObject effect;
    public GameObject lose;
  
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distanse, whatIsSolid1);
        if (hitInfo.collider != null)
        {
            for (int i = 0; i < cosm.Length; i++)
            {
                if (cosm[i] != null)
                {
                    Instantiate(effect, cosm[i].transform.position, Quaternion.identity);
                    Destroy(cosm[i]);
                }
                
            }
            lose.SetActive(true);
            
        }
    }
}
