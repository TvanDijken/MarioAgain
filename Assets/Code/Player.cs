using UnityEngine;

public class Player : Actor
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
  private SpriteRenderer SpriteRenderer;
  private int moveToLayer = 13;
  public Sprite StealthySprite;
  public BoxCollider2D bc2d;

  public new void Awake()
  {
    rb2d = GetComponent<Rigidbody2D>();
  }

  private void Start()
  {
    SpriteRenderer = GetComponent<SpriteRenderer>();
  }

  /// <summary>
  /// checks if the player is grounded and allowes jumping.
  /// </summary>
  public void Update()
  {
    if (isGrounded)
    {
      isJumping = false;
    }
  }

  public void FixedUpdate()
  {
    //lets the player move left, right and jump.
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
    if (Input.GetKey(KeyCode.F))
    {
      ChangeLayer();
    }
  }
  // reset the camera and player to its start position and reset any collectiblels and enemies.
  public void Die()
  {
    player.Reset();
    cameraController.Reset();
    Debug.Log("joe ded BOII!!!!!");
  }

  internal void Reset()
  {
    transform.position = new Vector3(-30f, -2.5f, 3f);
  }

  public void ChangeLayer()
  {   
      ///change layer for collision
      gameObject.layer = moveToLayer;
      Debug.Log("StelfModeAktiveeted");
    ///change sprite
    SpriteRenderer.sprite = StealthySprite; 
    SpriteRenderer.color = new Color(1, 1, 1, 1f);

    bc2d.size = new Vector3(0.72f, 0.47f, 1);
  }
}