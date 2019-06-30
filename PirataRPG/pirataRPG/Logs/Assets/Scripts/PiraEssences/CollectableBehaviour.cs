using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehaviour : MonoBehaviour
{
    private float accelX = -10f;
    private float currentSpeedX = 0;
    private float deltaX;
    private BoatPlayerBehaviour boatPlayerBehavior;
    private ScoreController scoreController;
    
    private void Awake() {

        boatPlayerBehavior = GameObject.Find("Player").GetComponent<BoatPlayerBehaviour>();
        scoreController = GameObject.Find("GlobalScripts").GetComponent<ScoreController>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
         currentSpeedX += accelX * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        deltaX = currentSpeedX * Time.deltaTime + accelX * (Mathf.Pow(Time.deltaTime, 2))/2;
        transform.Translate(new Vector3(deltaX, 0f));
        currentSpeedX += accelX * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("hit");
        if (gameObject.tag == "Enemy" && other.gameObject.name == "Player")
        {
            boatPlayerBehavior.OnHitted();
        }
        else if(other.gameObject.name == "Player")
        {
            scoreController.AddEssence(gameObject.tag);
        }
        Destroy(gameObject);
    }
}
