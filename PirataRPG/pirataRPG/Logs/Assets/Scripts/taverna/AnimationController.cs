using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Vector3 maxWalkSpeed = new Vector3(1f, 1f), maxRunSpeed = new Vector3(4f, 4f), currentSpeed;
    bool isAttacking, isRuning, isLookingRight = true;
    Animator currentAnimator;

    private void Awake() {
        currentAnimator = GetComponent<Animator>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Player")
        {
            isRuning = Input.GetButton("Fire3");
            isAttacking = Input.GetButton("Fire1");

            currentSpeed = new Vector3(
            Input.GetAxis("Horizontal") *  (isRuning ? maxRunSpeed.x : maxWalkSpeed.x),
            Input.GetAxis("Vertical") * (isRuning  ? maxRunSpeed.y : maxWalkSpeed.y)
            );
        }
        //currentSpeed *= Time.deltaTime;
        
        if (currentSpeed.x < 0)
        {
            isLookingRight = false;
        }
        else if (currentSpeed.x > 0)
        {
            isLookingRight = true;
        }

        transform.rotation = new Quaternion(0, !isLookingRight ? 180: 0, 0, 0);
        
        gameObject.GetComponent<Rigidbody>().velocity = currentSpeed;
        currentAnimator.SetBool("IsAttacking", isAttacking);
        currentAnimator.SetFloat("speed", currentSpeed.magnitude);

    }
}
