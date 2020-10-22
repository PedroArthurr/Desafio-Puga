using UnityEngine;

public class Rotating : MonoBehaviour
{
  void Update()
  {
    this.gameObject.transform.Rotate(Vector3.up);
  }
}
