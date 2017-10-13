using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class Player : MonoBehaviour
{
  //public float speed;
  public CameraController cameraController;
  private Rigidbody2D rb2d;
  public Transform deathZone;
  public float jumpSpeed;
  public float Walk;
  public float Jump;
  bool grounded;
  private bool isJumping = false;
  private bool isGrounded = true;
  private float degreesToCollision;
  private Vector2 spawn;
  private object Collision2DCollider;
  private object collision;
  void Awake()
  {
    rb2d = GetComponent<Rigidbody2D>();
  }

  internal void Reset()
  {
    transform.position = new Vector3(-10f, -3f, 0f);
  }

  public void Update()
  {
    if (isGrounded)
    {
      isJumping = false;
    }
  }

  void Die()
  {
    transform.position = new Vector3(-10f, -3f, 0f);
    //cameraController.Reset();
    Debug.Log("you died");
  }

  private void OnCollisionEnter2D(Collision2D c)
  {
    if (c.transform.tag == "Ground")
    {
      grounded = true;
    }
  }

  void FixedUpdate()
  {
    //float moveHorizontal = Input.GetAxis("Horizontal");
    //float moveVertical = Input.GetAxis("Vertical");

    //Vector2 movement = new Vector2(moveHorizontal, moveVertical);
    //rb2d.AddForce(movement * speed);


    if (Input.GetKey(KeyCode.A))
    {
      transform.Translate(Vector3.left * Walk);
    }
    else if (Input.GetKey(KeyCode.D))
    {
      transform.Translate(-Vector3.left * Walk);
    }

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