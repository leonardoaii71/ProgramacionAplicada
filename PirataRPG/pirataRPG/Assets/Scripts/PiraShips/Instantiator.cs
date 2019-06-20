using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{

    public List<GameObject> essences;
    public GameObject spike;
    const int essenceQuantity = 6;
    float nextTime;
    const float LOWERTIME = 1f, UPPERTIME = 2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InstantiatorcoRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator InstantiatorcoRoutine()
    {
        nextTime = Random.Range(LOWERTIME, UPPERTIME);
        yield return new WaitForEndOfFrame();
    }
}
