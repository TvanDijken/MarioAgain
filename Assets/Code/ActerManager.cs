using System.Collections.Generic;

public class ActerManager : Manager
{
  private static Dictionary<int, Actor> actors;

  public void ActorManager()
  {
    actors = new Dictionary<int, Actor>();
  }

  public static void RegisterActor(Actor actor)
  {
    actors.Add(actor.gameObject.GetInstanceID(), actor);
  }

  public static Actor GetActor(int ID)
  {
    if (actors.ContainsKey(ID))
      return actors[ID];
    return null;
  }

  //public void Reset()
  //{
  //  for (int i = 0; i < actors.Count; i++)
  //    actors[i].Reset();
  //}
}




