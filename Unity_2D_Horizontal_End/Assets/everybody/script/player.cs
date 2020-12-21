﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rb;

    Animator anim;

    public float speed;
    Vector2 movement;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(movement.x !=0)
        {
            transform.localScale = new Vector3(-movement.x, 1, 1);
        }
        SiwitchAnim();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    void SiwitchAnim()
    {
        anim.SetFloat("speed", movement.magnitude);
    }
}
