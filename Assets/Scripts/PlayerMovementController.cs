using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rigidbody;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // give the horizontal axis input (left - a, right - d)
        float h = Input.GetAxis("Horizontal");
        // give the vertical axis input (top - w, bottom - s)
        float v = Input.GetAxis("Vertical");
        Debug.Log("h = " + h + ", v = " + v);
        Vector2 dir = new Vector2(h, v);

        // setting the "normalized" speed of player from direction h and v 
        rigidbody.velocity = dir.normalized * speed;
        
        animator.SetBool("isFlyingLeft", h < 0);
        animator.SetBool("isFlyingRight", h > 0);
        animator.SetBool("isFlyingUp", v > 0);
        animator.SetBool("isFlyingBottom", v < 0);
    }
}
