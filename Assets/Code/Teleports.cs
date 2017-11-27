using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleports : MonoBehaviour
{
  public Player player;
  private Rigidbody2D rb2d;



  public void Awake()
  {
    rb2d = GetComponent<Rigidbody2D>();

  }

  public void OnTriggerEnter2D(Collider2D collision)
  {
     transform.position = new Vector3(-2.5f, -0.8f, 0f);
  }
}
