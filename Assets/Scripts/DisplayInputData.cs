using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using TMPro;

[RequireComponent(typeof(InputData))]
public class DisplayInputData : MonoBehaviour
{
    public GameObject cam;
    public TextMeshProUGUI leftVelocityDisplay;
    public TextMeshProUGUI rightVelocityDisplay;

    private InputData inputData;

    // Start is called before the first frame update
    void Start()
    {
        inputData = GetComponent<InputData>();
        //Camera cam1 = cam.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //'deviceVelocity' is the input data we get from left controller, and stored it into vector3
        //device velocity = one of the data inputs
        //can replace it with other data inputs, ex: position, rotation
        if (inputData.leftController.TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 leftVelocity))
        {
            Debug.Log("left controller is moving");
            leftVelocityDisplay.text = leftVelocity.magnitude.ToString("F2");//second decimal point
            if (leftVelocity.x < 0)
            {
                Debug.Log("move cam position");
                if (leftVelocity.y < 0)
                {
                    float rotateSpeed = 2.0f;
                    //float rotation = rotateSpeed;
                    //Vector3 rotation = new Vector3(0, leftVelocity);
                    cam.transform.position += leftVelocity;
                }
              

            }
        }
        if (inputData.rightController.TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 rightVelocity))
        {
            Debug.Log("right controller is moving");
            rightVelocityDisplay.text = rightVelocity.magnitude.ToString("F2");
            if (leftVelocity.x < 0)
            {
                Debug.Log("move cam position");
                cam.transform.position += rightVelocity;

            }
        }



    }
}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.XR;
//using UnityEngine.UI;


//public class DisplayInputData : MonoBehaviour
//{
//    public InputData inputData;


//    // Start is called before the first frame update
//    void Start()
//    {
//        inputData = GetComponent<InputData>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        //bool triggerValue;
//        //if (inputData.leftController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out triggerValue) && triggerValue)
//        //{
//        //    Debug.Log("Trigger button is pressed.");
//        //}


//        //left controller
//        if (inputData.leftController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out bool leftTriggerValue))
//        {
//            Debug.Log("Left Trigger button is pressed.");
//        }

//        if (inputData.leftController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.gripButton, out bool leftGripValue))
//        {
//            Debug.Log("Left Grip button is pressed.");
//        }

//        if (inputData.leftController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.devicePosition, out Vector3 leftPosition))
//        {
//            Debug.Log("Left controller is moving at: " + leftPosition);
//        }

//        if (inputData.leftController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceVelocity, out Vector3 leftVelocity))
//        {
//            Debug.Log("Left controller is speeding at: " + leftVelocity);
//        }

//        if (inputData.leftController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceRotation, out Quaternion leftRotation))
//        {
//            Debug.Log("Left controller is rotating at: " + leftRotation);
//        }

//        //right controller
//        if (inputData.rightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out bool rightTriggerValue))
//        {
//            Debug.Log("Right Trigger button is pressed.");
//        }

//        if (inputData.rightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.gripButton, out bool rightGripValue))
//        {
//            Debug.Log("Right Grip button is pressed.");
//        }

//        if (inputData.rightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.devicePosition, out Vector3 rightPosition))
//        {
//            Debug.Log("Right controller is moving at: " + rightPosition);
//        }

//        if (inputData.rightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceVelocity, out Vector3 rightVelocity))
//        {
//            Debug.Log("Right controller is speeding at: " + rightVelocity);
//        }

//        if (inputData.rightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceRotation, out Quaternion rightRotation))
//        {
//            Debug.Log("Right controller is rotating at: " + rightRotation);
//        }
//    }
//}
