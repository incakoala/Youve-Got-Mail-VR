using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
[RequireComponent(typeof(AudioSource))]

public class BookshelfCanvasManager : MonoBehaviour
{
  public GameObject CanvasObject;
  public AudioSource aud;
  // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    // Deactivate bookshelf canvas when all book sockets have been occupied
    GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("BookSocket");
    foreach (GameObject targetObject in taggedObjects)
    {
      bool socketSelected = targetObject.GetComponent<XRSocketInteractor>().GetOldestInteractableSelected() != null;
      if (socketSelected)
      {
        continue;
      }
      else if (!socketSelected) {
        return;
      }
    }
    if (!aud.isPlaying) { 
      aud.Play(); 
      Destroy(aud, aud.clip.length);
    }
    Destroy(CanvasObject);
  }
}
