using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInfo : MonoBehaviour
{
    [Header("Set in Inspector")]
    public Text speedText;
    public Text accelerationText;
    public Text detectionText;

    // Update is called once per frame
    void Update()
    {
        speedText.text = "Speed: " + CarPathing.carPathing.speed.ToString("F2") + " m/s";
        accelerationText.text = "Acceleration: " + CarPathing.carPathing.acceleration.ToString("F2") + " m\u00b2/s";
        detectionText.text = "Pedestrian detected: " + RayCast.rayCast.warning;
    }

}
