using UnityEngine;

public class Manager
{
  public virtual void Awake()
  {
    Debug.Log(string.Format("instance {0} has now awaken"));
  }

  public virtual void Start()
  {
    Debug.Log(string.Format("instance {0} has now starting"));

  }
}
