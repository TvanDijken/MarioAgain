using UnityEngine;

public class Player : MonoBehaviour
{
  public float speed;
  private Rigidbody2D rb2d;
  bool grounded;
  public float jumpSpeed;
  public CameraController cameraController;

  void Awake()
  {
    rb2d = GetComponent<Rigidbody2D>();
  }

  void OnCollisionEnter2D(Collision2D other)
  {
    if (other.transform.tag == "Ground")
    {
      grounded = true;
    }
  }
  void Die()
  {
    transform.position = new Vector3(0f, 1.5f, 0f);
    cameraController.Reset();
    Debug.Log("you died");
  }

    void FixedUpdate()
  {
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector2 movement = new Vector2(moveHorizontal, moveVertical);
    rb2d.AddForce(movement * speed);

    if (grounded)
    {
      if (Input.GetKey(KeyCode.Space))
      {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpSpeed);
        grounded = false;
      }
    }
  }
}