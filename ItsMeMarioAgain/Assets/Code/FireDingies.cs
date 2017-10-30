﻿using System.Collections;
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

  void Start()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }

  private void OnTriggerStay2D(Collider2D collision)
  {
    ChangeLayer();
  }

  public void ChangeLayer()
  {
    spriteRenderer.sprite = fireStage1;
    spriteRenderer.sprite = fireStage2;
    spriteRenderer.sprite = fireStage3;
    spriteRenderer.sprite = fireStage4;

  }
}