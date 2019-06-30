using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatPlayerBehaviour : MonoBehaviour
{
    private Animator animator;
    float speed = 5f;
    Vector3 deltaPos;
    const float VERTICALUPPERLIMIT = 4f, VERTICALLOWERLIMIT = -4f;
    private const int _startingHitPoints = 3;
    public int HitPoints;
    private bool SpikeHit = false;
    private int cycle;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        HitPoints = _startingHitPoints;
    }

    // Update is called once per frame
    void Update()
    {
        deltaPos = new Vector3(0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        animator.SetFloat("orientation", deltaPos.y);

        gameObject.transform.Translate(deltaPos);
        gameObject.transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(transform.position.y, VERTICALLOWERLIMIT, VERTICALUPPERLIMIT));
        
        if (SpikeHit)
        {
            StartCoroutine(StartGrace());
        }
        if (cycle >= 5)
            SpikeHit = false;

    }

    public void OnHitted(){
        if (!SpikeHit)
        {
            HitPoints--;
            Destroy(GameObject.Find("HitPoints").transform.GetChild(0).gameObject);

            if (HitPoints == 0)
            {
                //Game Over
                gameObject.SetActive(false);
            }

            SpikeHit = true;
        }
    }

    IEnumerator StartGrace()
    { 
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            animator.enabled = false;
            cycle++;

            yield return new WaitForSeconds(2);
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            animator.enabled = true;
    }

}
