using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class ComputerManager : MonoBehaviour
{
  AudioSource aud;
  public AudioClip YouveGotMailAudio;
  public AudioClip EmailAudio;
  public GameObject SignOnBackground;
  public GameObject ConnectionBackground;
  public GameObject YouveMailBackground;
  public GameObject EmailBackground;

  // Start is called before the first frame update
  void Start()
  {
    aud = GetComponent<AudioSource>();
  }

  // Update is called once per frame
  void Update()
  {
    // Manage canvases
    GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("TaskCanvas");
    foreach (GameObject targetObject in taggedObjects)
    {
      bool taskCompleted = (targetObject.activeSelf == false);
      if (taskCompleted)
      {
        continue;
      }
      else if (!taskCompleted)
      {
        SignOnBackground.SetActive(false);
        return;
      }
    }
    SignOnBackground.SetActive(true);


    // Manage sound
    if (ConnectionBackground.activeSelf && !aud.isPlaying)
    {
      SignOnBackground.SetActive(false);
      ConnectionBackground.SetActive(false);
      YouveMailBackground.SetActive(true);
      if (YouveMailBackground.activeSelf) {
        aud.clip = YouveGotMailAudio;
        aud.loop = false;
        aud.volume = 0.2f;
        aud.Play();
      }
    }
  }
}
