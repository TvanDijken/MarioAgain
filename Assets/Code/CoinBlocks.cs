using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBlocks : MonoBehaviour
{
  [SerializeField]
  public int spawnAmount = 1;
  public int currentSpawnAmount;
  public int maxCoins = 5;
  private int coinsSpent = 0;
  private int moveToLayer = 11;
  private SpriteRenderer spriteRenderer;
  public Sprite emptyBlockSprite;
  public UI inter;

  private void Start()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
    inter = GameObject.FindWithTag("Interface").GetComponent<UI>();
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    switch (collision.gameObject.layer)
    {
      case 9:

        if (coinsSpent < maxCoins)
        {
          inter.AddCoin();
          inter.AddScore(100);
          Debug.Log("Added a coin");
          coinsSpent++;
          ChangeLayer();
        }
        Debug.Log("Player hit us");
        break;
    }
  }

 public void ChangeLayer()
  {
    ///change layer for collision
    gameObject.layer = moveToLayer;
    Debug.Log("Coin block empty");
    ///change sprite
    spriteRenderer.sprite = emptyBlockSprite;
  }
}
