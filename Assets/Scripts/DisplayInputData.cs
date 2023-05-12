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
    float rotateAngle = 10.0f;

    private InputData inputData;

    public float Sensitivity
    {
        get { return sensitivity; }
        set { sensitivity = value; }
    }
    [Range(0.1f, 9f)][SerializeField] float sensitivity = 2f;
    [Tooltip("Limits vertical camera rotation. Prevents the flipping that happens when rotation goes above 90.")]
    [Range(0f, 90f)][SerializeField] float yRotationLimit = 88f;

    Vector2 rotation = Vector2.zero;


    // Start is called before the first frame update
    void Start()
    {
        inputData = GetComponent<InputData>();
        cam = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        //'deviceVelocity' is the input data we get from left controller, and stored it into vector3
        //device velocity = one of the data inputs
        //can replace it with other data inputs, ex: position, rotation
        if (inputData.leftController.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 turnLeft))
        {
            Debug.Log("left controller is moving");
            leftVelocityDisplay.text = turnLeft.x.ToString("F2");//second decimal point

            rotation.x += turnLeft.x * sensitivity;
            var xQuat = Quaternion.AngleAxis(rotation.x, Vector3.up);
            transform.localRotation = xQuat;

        }
        if (inputData.rightController.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 turnRight))
        {
            Debug.Log("right controller is moving");
            rightVelocityDisplay.text = turnRight.x.ToString("F2");
            if (turnRight.x > 0)
            {
                Debug.Log("move cam position");
                //cam.transform.position += turnRight;

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
