using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class DisplayInputData : MonoBehaviour
{
    private InputData inputData;

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
            Debug.Log("Left controller is moving.");
        }

        if (inputData.leftController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceVelocity, out Vector3 leftVelocity))
        {
            Debug.Log("Left controller is speeding.");
        }

        if (inputData.leftController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceRotation, out Quaternion leftRotation))
        {
            Debug.Log("Left controller is rotating.");
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
            Debug.Log("Right controller is moving.");
        }

        if (inputData.rightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceVelocity, out Vector3 rightVelocity))
        {
            Debug.Log("Right controller is speeding.");
        }

        if (inputData.rightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceRotation, out Quaternion rightRotation))
        {
            Debug.Log("Right controller is rotating.");
        }
    }
}
