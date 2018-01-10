using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  public Player player;

  void Update()
  {
    ///enemy moves left
    transform.Translate(Vector2.left * Time.deltaTime);
  }

  /// <summary>
  /// the enemy can kill the player by hitting him and can be killed when the player hits the top of the enemy collider and makes the player respawn ones killed by this enemy.
  /// </summary>
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
        player.Die(); 
      }
    }
  }
}
