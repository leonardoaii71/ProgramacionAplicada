using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatPlayerBehaviour : MonoBehaviour
{
    private Animator animator;
    float speed = 3f;
    Vector3 deltaPos;
    const float VERTICALUPPERLIMIT = 4f, VERTICALLOWERLIMIT = -4f;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deltaPos = new Vector3(0, Input.GetAxis("Vertical") * speed * Time.deltaTime);

        animator.SetFloat("orientation", deltaPos.y);
        Debug.Log(deltaPos.y);

        gameObject.transform.Translate(deltaPos);
        gameObject.transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(transform.position.y, VERTICALLOWERLIMIT, VERTICALUPPERLIMIT));
    }
}
