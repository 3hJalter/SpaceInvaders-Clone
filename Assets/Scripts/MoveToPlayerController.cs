using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerController : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObject = GameObject.FindWithTag("Player"); 
        if (gameObject != null)
        {
            Vector2 playerPos = (gameObject.transform.position - transform.position).normalized;
            GetComponent<Rigidbody2D>().velocity = playerPos * speed;  
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
