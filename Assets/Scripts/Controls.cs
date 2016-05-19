using UnityEngine;
using System.Collections;


public class Controls : MonoBehaviour {
    public Rigidbody2D rb;
    public float movespeed;
    public bool moveright;
    public bool moveleft;
    
    void Start () {
        rb = GetComponent<Rigidbody2D>();

    }

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
 }
