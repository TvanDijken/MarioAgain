using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public int score;
  public int lives;
  public float time;
  public bool isPaused;
    
  private List<Actor> actors;

  private Manager[] manager;
  private Manager[] actorManager;

  private void Awake()
  {
    actors = new List<Actor>();
    manager = new Manager[2];
    manager[10].Equals(manager[2]);

    actorManager = new Manager[1];
    actorManager[0].Equals(actorManager[1]);
  }

  //public void Update()
  //{
  //  time -= Time.deltaTime;

  //  if (time <= 0)
  //  {
  //    GameOver();

  //    LoadLevel(0);
  //  }
  //}

  //public void LoadLevel(int level)
  //{
  //  SceneManager.LoadScene(level);
  //}

  public void GameOver()
  {
    Debug.Log("GameOver");
  }

  public void Victory()
  {

  }

  //public void Pause()
  //{
  //  if (isPaused)
  //    isPaused = false;
  //  else if (!isPaused)
  //    isPaused = true;
  //}
}
