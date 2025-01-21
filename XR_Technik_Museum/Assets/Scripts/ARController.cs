using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia; 

public class ARController : MonoBehaviour
{
    /// <summary>
    /// Reference to the text field containing
    /// the current scale factor
    /// </summary> 
    public Text scaleFactorLabel;

    /// <summary>
    /// Reference to the text field containing
    /// the distance between ar camera and image target 
    /// </summary>
    public Text distanceLabel;

    /// <summary>
    /// Reference to the image target for 
    /// distance calculation
    /// </summary>
    public Transform ImageTargetTransform;

    /// <summary>
    /// Inital Scale factor from vuforia configuration
    /// </summary> 
    private float initalScaleFactor;

    /// <summary>
    /// Saves the current scale factor of the content
    /// </summary>
    private float currentScaleFactor;

    // Start is called before the first frame update
    void Start()
    {
        initalScaleFactor = VuforiaConfiguration.Instance.Vuforia.VirtualSceneScaleFactor;
        currentScaleFactor = initalScaleFactor; 
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, ImageTargetTransform.position);
        distanceLabel.text = distance / currentScaleFactor + " m";
    }

    public void SetSceneScale(float scale)
    {
        currentScaleFactor = initalScaleFactor / scale;
        VuforiaConfiguration.Instance.Vuforia.VirtualSceneScaleFactor = currentScaleFactor;

        scaleFactorLabel.text = "1 : " + currentScaleFactor;

    }
}
