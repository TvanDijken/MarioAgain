using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDingies : MonoBehaviour
{
  private SpriteRenderer spriteRenderer;
  public Sprite fireEmpty;
  public Sprite fireStage1;
  public Sprite fireStage2;
  public Sprite fireStage3;
  public Sprite fireStage4;
  public Player player;

  void Start()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }

  public void OnCollisionEnter2D(Collision2D collision)
  {
    player.Reset();
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    ChangeLayer();
  }

  public void ChangeLayer()
  {
    spriteRenderer.sprite = fireStage4;
  }
}
