using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    public float speed = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void FixedUpdate()
    {
        float horiz = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * horiz * speed;   
    }
}
