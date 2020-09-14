using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour
{

    public float JumpForce;
    public Rigidbody2D Body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        transform.position = new Vector3(0, collision.transform.position.y + 1);
        Body.velocity = Vector3.zero;

        Body.AddForce( new Vector2(0, JumpForce) );


    }
}
