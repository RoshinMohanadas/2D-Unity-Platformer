using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rBody;
    private Animator anim;
    private SpriteRenderer sprite;

    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rBody.velocity = new Vector2(dirX * moveSpeed, rBody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rBody.velocity = new Vector2(rBody.velocity.x, jumpForce);
        }

        UpdateAnimation(dirX);

    }

    private void UpdateAnimation(float dirX)
    {
        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false; 
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = true;
        }
        else
            anim.SetBool("running", false);
    }
}
