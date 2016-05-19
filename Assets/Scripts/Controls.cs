using UnityEngine;
using System.Collections;


public class Controls : MonoBehaviour {
    public Rigidbody2D rb;
    public float movespeed;
    public bool moveright;
    public bool moveleft;
    
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update () {



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);

        }

        if (moveright)
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
        }
        if (moveleft)
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        }

    }
    public void goright ()
    {
        

    }
    public void goleft ()
    {
        rb.velocity = new Vector2(-movespeed, rb.velocity.y);

    }
}
