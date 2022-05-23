using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockAnimator : MonoBehaviour
{
  private const float
      hoursToDegrees = 360f / 12f,
      minutesToDegrees = 360f / 60f,
      secondsToDegrees = 360f / 60f;

  public Transform hours, minutes, seconds;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    TimeSpan timespan = DateTime.Now.TimeOfDay;
    hours.localRotation = Quaternion.Euler((float)timespan.TotalHours * hoursToDegrees, 0f, 0f);
    minutes.localRotation = Quaternion.Euler((float)timespan.TotalMinutes * minutesToDegrees, 0f, 0f);
    seconds.localRotation = Quaternion.Euler((float)timespan.TotalSeconds * secondsToDegrees, 0f, 0f);
    // seconds.Rotate(new Vector3((float)timespan.TotalSeconds * secondsToDegrees, 0f, 0f));
  }
}
