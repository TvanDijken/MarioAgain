﻿using UnityEngine;

public class Player : MonoBehaviour
{
  //public float speed;
  public CameraController cameraController;
  private Rigidbody2D rb2d;
  public Transform deathZone;
  public float jumpSpeed;
  public float Walk;
  public float Jump;
  private bool isJumping = false;
  private bool isGrounded = true;
  public Player player;
  public float speed;

  void Awake()
  {
    rb2d = GetComponent<Rigidbody2D>();
  }

  public void Start()
  {
  }

  public void Die()
  {
    player.Reset();
    cameraController.Reset();
    Debug.Log("you died");
  }

  internal void Reset()
  {
    transform.position = new Vector3(-30f, -2.5f, 3f);
  }

  public void Update()
  {
    if (isGrounded)
    {
      isJumping = false;
    }
  }

  public void FixedUpdate()
  {
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector2 movement = new Vector2(moveHorizontal, moveVertical);
    rb2d.AddForce(movement * speed);

    //if (Input.GetKey(KeyCode.A))
    //{
    //  transform.Translate(Vector3.left * Walk);
    //}
    //else if (Input.GetKey(KeyCode.D))
    //{
    //  transform.Translate(-Vector3.left * Walk);
    //}

    if (Input.GetKey(KeyCode.Space))
    {
      if (isGrounded)

        if (!isJumping)
        {
          rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
          rb2d.AddForce(new Vector2(0, jumpSpeed * 100));
          isJumping = true;
        }
    }
  }
}