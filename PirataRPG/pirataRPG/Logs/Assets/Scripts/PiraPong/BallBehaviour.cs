using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

    public bool? isLeftPlayer;
    
    float _startingSpeed = 7f;

	// Use this for initialization
	void Start () {
        UpdateBallState();
	}
	
	// Update is called once per frame
	void Update()
    {
        if (isLeftPlayer != null && Input.GetButtonDown("Fire1"))
        {
            if (gameObject.transform.parent.transform.position.x < gameObject.transform.position.x)
            {
                _startingSpeed = -_startingSpeed;
            }

            gameObject.transform.SetParent(null);

            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-_startingSpeed, _startingSpeed * (Random.Range(0, 2) == 0 ? 1 : -1));

            isLeftPlayer = null;
        }
        
    }

    public void UpdateBallState()
    {
        if (transform.parent.name == "LeftPlayer")
            isLeftPlayer = true;
        else if (transform.parent.name == "RightPlayer")
            isLeftPlayer = false;
        else
            isLeftPlayer = null;

        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

    }

}
