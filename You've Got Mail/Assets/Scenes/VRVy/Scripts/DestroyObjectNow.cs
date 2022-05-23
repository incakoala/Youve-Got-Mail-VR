using UnityEngine;

/// <summary>
/// Destroys object after a few seconds
/// </summary>
public class DestroyObjectNow : MonoBehaviour
{
  public GameObject ObjectToDestroy;
  public void DestroyNow()
  {
      Destroy(ObjectToDestroy);
  }
}
