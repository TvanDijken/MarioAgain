using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public int score;
  public int lives;
  public float time;
  public bool isPaused;

  public void Update()
  {
    time -= Time.deltaTime;

    if (time <= 0)
    {
      GameOver();

      LoadLevel(0);
    }
  }

  public void LoadLevel(int level)
  {
    SceneManager.LoadScene(level);
  }

  public void GameOver()
  {
    Debug.Log("GameOver");
  }

  public void Victory()
  {

  }

  public void Pause()
  {
    if (isPaused)
      isPaused = false;
    else if (!isPaused)
      isPaused = true;
  }
}
