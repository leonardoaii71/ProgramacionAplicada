using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//mover a deadzones
public class DeadZoneController : MonoBehaviour
{
public GameObject Ball;
public GameObject LeftPlayer;
public GameObject RightPlayer;
public GlobalScript globalScript;
bool isLeftDeadZone;


    // Start is called before the first frame update
    void Start()
    {
        isLeftDeadZone = gameObject.name == "leftDeadZone";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.name != "Ball")
            return;

        globalScript.incrementScore(isLeftDeadZone);
        Ball.transform.SetParent(isLeftDeadZone ? RightPlayer.transform : LeftPlayer.transform);        
        Ball.transform.position = new Vector3(isLeftDeadZone ? -2.5f: 2.5f, 0);
        Ball.SendMessage("UpdateBallState");
        Debug.Log("collision detected");
    }
}
