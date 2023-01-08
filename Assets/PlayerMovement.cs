using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rBody;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rBody.velocity = new Vector2(dirX * 7f, rBody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rBody.velocity = new Vector2(rBody.velocity.x, 14);
        }
    }
}
