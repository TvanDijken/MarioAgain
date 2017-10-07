using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
  public Transform character;
  public Player player;
  private Vector3 offset;
  private Vector3 startPosition;

  //todo Reset camera when the player dies

  // Use this for initialization
  void Start()
  {
    startPosition = transform.position;
    offset = transform.position - character.transform.position;
  }
  //public void Reset()
  //{
  //  transform.position = startPosition;
  //}
  
  // updates after all the other updates
  void LateUpdate()
  {

    if (character.position.x - transform.position.x > 0)
    {
      // Moves the camera with Mario (does not move in the Y-Axis)
      Vector3 targetCamPos = new Vector3(character.position.x + offset.x, transform.position.y, transform.position.z);
      transform.position = targetCamPos;
    }
  }
}