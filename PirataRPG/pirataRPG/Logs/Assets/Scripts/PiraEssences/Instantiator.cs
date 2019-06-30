using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public List<GameObject> essences;
    public GameObject spike;
    private GameObject newItem;
    const int essenceQuantity = 6;
    float nextTime;
    private float spikeRatio = 0.3f;
    const float LOWERTIME = 1f, UPPERTIME = 2f;
    const float LOWERLIMIT = -4f, UPPERLIMIT = 4f;

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

        while (true)
        {
            yield return new WaitForSeconds(nextTime);

            if (Random.Range(0f, 1f) > spikeRatio % 1){
                newItem = spike;
            }
            else
            {
                newItem = essences[Random.Range(0, 6)];
            }

            Instantiate(newItem, new Vector3(11f, Random.Range(LOWERLIMIT, UPPERLIMIT)), Quaternion.identity);
            spikeRatio *= 1.2f;
        }
    }
}
