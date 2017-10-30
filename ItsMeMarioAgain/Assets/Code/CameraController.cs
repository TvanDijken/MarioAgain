using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
  public Transform character;
  public Player player;

  private Vector3 offset;
  private Vector3 startPosition;

  // Use this for initialization
  void Start()
  {
    startPosition = transform.position;
    offset = transform.position - character.transform.position;
  }
  public void Reset()
  {
    // Resets the camera to its start position
    transform.position = startPosition;
  }

  // Updates after all the other updates
  void LateUpdate()
  {
    if (character.position.x - transform.position.x > -3)
    {
      // Moves the camera with Mario (does not move in the Y-Axis) sets a height of 7 for the camera
      Vector3 targetCamPos = new Vector3(character.position.x + offset.x, -2, character.position.z + offset.z);
      transform.position = targetCamPos;
    }
  }
}