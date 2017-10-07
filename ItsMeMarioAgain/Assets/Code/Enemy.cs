using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  public Player player;
  // Use this for initialization
  void Start()
  {
    //if (player == null)
    //  player = GameObject.FindWithTag("Player").GetComponent<Player>();
  }

  // Update is called once per frame
  void Update()
  {
    ///enemy can move left
    transform.Translate(Vector2.left * Time.deltaTime);
  }
  private void OnCollisionEnter2D(Collision2D c)
  {
    Vector2 upVector = transform.up;
    Vector2 toCollision = c.transform.position - transform.position;

    if (c.gameObject.layer == 9)
    {
      if ((Vector2.Dot(toCollision, upVector)) >
         ((toCollision.magnitude * upVector.magnitude * Mathf.Cos(30 * Mathf.Deg2Rad))))
      {
        gameObject.SetActive(false);
      }
      else
      {
        player.Reset();
      }
    }
  }
}
