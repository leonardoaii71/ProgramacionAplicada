using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    private bool wait = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.1f, 0, 0);
        
        if (transform.position.x < -14.5 && !wait)
        {
            Instantiate(gameObject, new Vector3(20.4f, gameObject.transform.position.y, 0), Quaternion.identity);
            wait = true;
        }

        if (transform.position.x < -38)
        {
            Destroy(gameObject);
        }
    }
}
