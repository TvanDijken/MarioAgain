using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
  protected float degreesToCollision;

  void Awake()
  {
    degreesToCollision = 30;
  }
  protected bool CalculateDotProduct(Vector2 toCollision, Vector2 direction)
  {
    return Vector2.Dot(toCollision, transform.up) > (toCollision.magnitude * transform.up.magnitude * Mathf.Cos(degreesToCollision * Mathf.Deg2Rad));
  }
}
