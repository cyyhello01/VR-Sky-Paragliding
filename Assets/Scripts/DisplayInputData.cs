using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;


public class DisplayInputData : MonoBehaviour
{
    public InputData inputData;
   

    // Start is called before the first frame update
    void Start()
    {
        inputData = GetComponent<InputData>();
    }

    // Update is called once per frame
    void Update()
    {
        //bool triggerValue;
        //if (inputData.leftController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out triggerValue) && triggerValue)
        //{
        //    Debug.Log("Trigger button is pressed.");
        //}


        //left controller
        if (inputData.leftController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out bool leftTriggerValue))
        {
            Debug.Log("Left Trigger button is pressed.");
        }

        if (inputData.leftController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.gripButton, out bool leftGripValue))
        {
            Debug.Log("Left Grip button is pressed.");
        }

        if (inputData.leftController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.devicePosition, out Vector3 leftPosition))
        {
            Debug.Log("Left controller is moving at: " + leftPosition);
        }

        if (inputData.leftController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceVelocity, out Vector3 leftVelocity))
        {
            Debug.Log("Left controller is speeding at: " + leftVelocity);
        }

        if (inputData.leftController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceRotation, out Quaternion leftRotation))
        {
            Debug.Log("Left controller is rotating at: " + leftRotation);
        }

        //right controller
        if (inputData.rightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out bool rightTriggerValue))
        {
            Debug.Log("Right Trigger button is pressed.");
        }

        if (inputData.rightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.gripButton, out bool rightGripValue))
        {
            Debug.Log("Right Grip button is pressed.");
        }

        if (inputData.rightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.devicePosition, out Vector3 rightPosition))
        {
            Debug.Log("Right controller is moving at: " + rightPosition);
        }

        if (inputData.rightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceVelocity, out Vector3 rightVelocity))
        {
            Debug.Log("Right controller is speeding at: " + rightVelocity);
        }

        if (inputData.rightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceRotation, out Quaternion rightRotation))
        {
            Debug.Log("Right controller is rotating at: " + rightRotation);
        }
    }
}
