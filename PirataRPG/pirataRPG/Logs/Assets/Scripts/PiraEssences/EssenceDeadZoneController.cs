using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssenceDeadZoneController : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
