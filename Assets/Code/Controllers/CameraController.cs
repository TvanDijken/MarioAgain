﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
  public Transform character;
  public Player player;

  private Vector3 offset;
  public Vector3 startPosition;

  // Use this for initialization
  void Start()
  {
    startPosition = transform.position;
    offset = transform.position - character.transform.position;
  }

  void LateUpdate()
  {
    if (character.position.x - transform.position.x > -3)
    {
      // Moves the camera with Mario (does not move in the Y-Axis) sets a height for the camera
      Vector3 targetCamPos = new Vector3(character.position.x + offset.x, -2, character.position.z + offset.z);
      transform.position = targetCamPos;
    }
  }

  public void Reset()
  {
    // Resets the camera to its start position
    transform.position = new Vector3(-30, -3, 3);
  }
}