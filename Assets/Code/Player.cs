using UnityEngine;

public class Player : MonoBehaviour
{
  public CameraController cameraController;
  private Rigidbody2D rb2d;
  public float JumpSpeed;
  public float Walk;
  public float Jump;
  private bool isJumping = false;
  private bool isGrounded = true;
  public Player player;
  public GameObject powerUp;

  void Awake()
  {
    rb2d = GetComponent<Rigidbody2D>();
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
          rb2d.AddForce(new Vector2(0, JumpSpeed * 100));
          isJumping = true;
        }
    }
  }

  public void Die()
  {
    player.Reset();
    cameraController.Reset();
    Debug.Log("you died");
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
  }

  internal void Reset()
  {
    transform.position = new Vector3(-30f, -2.5f, 3f);
  }
}