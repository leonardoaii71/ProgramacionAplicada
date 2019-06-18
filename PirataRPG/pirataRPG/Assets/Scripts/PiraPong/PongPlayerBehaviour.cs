using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongPlayerBehaviour : MonoBehaviour {
    
    public int UPPERLIMIT = 3, LOWERLIMIT = -3;

    public bool _isLeftPlayer;
    private float Speed = 10f;
    public Vector3 _deltaPos;
    public static bool _onePlayer;
    public GameObject _ball;

    public void Awake()
    {
        _isLeftPlayer = gameObject.name == "LeftPlayer";
        _ball = GameObject.Find("Ball");
    }

	// Use this for initialization
	void Start () {
        _onePlayer = true;
	}
	

	// Update is called once per frame
	void Update () {
        float desde, hasta;

        desde = gameObject.transform.position.y < _ball.transform.position.y ? 
                gameObject.transform.position.y : _ball.transform.position.y;

        hasta = gameObject.transform.position.y > _ball.transform.position.y ? 
                gameObject.transform.position.y : _ball.transform.position.y;

        if(_onePlayer && !_isLeftPlayer){
            transform.position = new Vector3(transform.position.x,
                                        Mathf.Clamp(Mathf.Lerp(desde, hasta, 0.5f), LOWERLIMIT, UPPERLIMIT), 
                                        transform.position.z);
             return;
        }

        _deltaPos = new Vector3(0f, (
                _isLeftPlayer 
                 ? Input.GetAxis("LeftPlayer")
                 : Input.GetAxis("Vertical")) * Speed * Time.deltaTime);
                    
        transform.Translate(_deltaPos);
        transform.position = new Vector3(
                transform.position.x, 
                Mathf.Clamp(transform.position.y, LOWERLIMIT, UPPERLIMIT),
                 transform.position.z);
	
        }
}
