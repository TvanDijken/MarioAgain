using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class PauseMenu : MonoBehaviour
{

  public GameObject PauseUI;

  private bool paused = false;

  public void Start()
  {
    PauseUI.SetActive(false);
  }
  public void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
      paused = !paused;
    }
    if (paused)
    {
      PauseUI.SetActive(true);
      Time.timeScale = 0;
    }
    else if (!paused)
    {
      PauseUI.SetActive(false);
      Time.timeScale = 1;
    }

  }
  public void Resume()
  {
    paused = false;
  }
  public void Restart()
  {
    SceneManager.LoadScene("Scene/mario");
  }
  public void Mainmenu()
  {
    SceneManager.LoadScene("Scene/mainmenu");
  }
  public void Quit()
  {
    Application.Quit();
  }
  public void StartGame()
  {
    SceneManager.LoadScene("mario");
  }
}