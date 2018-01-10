using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
  private static int score;
  public Text scoreText;
  private static int coins;
  public Text coinText;
  private static float time;
  public Text timeText;
  private static string world;
  public Text worldText;
  private static int lives;
  public Text livesText;
  private bool timeIsRunning;
  private static bool gameStarted;

  /// Use this for initialization
  private void Awake()
  {
    if (!gameStarted)
    {
      Reset();
      gameStarted = true;
    }
    else
    {
      ShowInterface();
    }

    StartGame();
  }

  private void Update()
  {
    if (timeIsRunning)
    {
      time -= Time.deltaTime;
      timeText.text = string.Format("Time:\r\n{0:000}", time);
    }
  }

  public void Reset()
  {
    coins = 0;
    lives = 3;
    score = 0;
    time = 500;
    world = "World : \r\n1-1";
    timeIsRunning = false;
  }

  public void StartGame()
  {
    timeIsRunning = true;
  }

  public void GameOver()
  {
    Reset();
  }

  public void AddScore(int score)
  {
    UI.score += score;
    scoreText.text = string.Format("Score:\r\n{0:000000}", UI.score);
    Debug.Log("het werkt");
  }

  public void AddCoin()
  {
    coins++;

    if (coins > 99)
    {
      lives++;
      coins = 0;
    }
    coinText.text = string.Format("Coins:\r\n{0:00}", coins);
  }

  public void ChangeWorld(int world, int level)
  {
    UI.world = string.Format("World:r\n{0}-{1}", world, level);
    worldText.text = UI.world;
  }

  public void AddLife(int amount)
  {
    lives += amount;
    livesText.text = string.Format("Mario x {0}", lives);
  }

  public void SetTime(float time)
  {
    UI.time = time;
    timeText.text = string.Format("Time:\r\n{0:000}", time);
  }

  /// <summary>
  /// sets the standerd text for the canvas to display on the start of the game.
  /// </summary>
  private void ShowInterface()
  {
    scoreText.text = string.Format("Score:\r\n{0:000000}", UI.score);
    timeText.text = string.Format("Time:\r\n{0:000}", time);
    livesText.text = string.Format("Mario x {0}", lives);
    worldText.text = world;
    coinText.text = string.Format("Coins:\r\n{0:00}", coins);
  }
}
