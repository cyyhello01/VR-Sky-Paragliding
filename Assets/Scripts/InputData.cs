using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;

public class InputData : MonoBehaviour
{
    public UnityEngine.XR.InputDevice leftController;
    public UnityEngine.XR.InputDevice rightController;

// Start is called before the first frame update
    void Start()
    {
       
        //get left hand controller
        var leftHandedControllers = new List<UnityEngine.XR.InputDevice>();
        var desiredLeftCharacteristics = UnityEngine.XR.InputDeviceCharacteristics.HeldInHand | UnityEngine.XR.InputDeviceCharacteristics.Left | UnityEngine.XR.InputDeviceCharacteristics.Controller;
        UnityEngine.XR.InputDevices.GetDevicesWithCharacteristics(desiredLeftCharacteristics, leftHandedControllers);

        //foreach (var device in leftHandedControllers)
        //{
        //    Debug.Log(string.Format("Device name '{0}' has characteristics '{1}'", device.name, device.characteristics.ToString()));
        //}

        if (leftHandedControllers.Count > 0)
        {
            leftController = leftHandedControllers[0];
        }

        //get right hand controller
        var rightHandedControllers = new List<UnityEngine.XR.InputDevice>();
        var desiredRightCharacteristics = UnityEngine.XR.InputDeviceCharacteristics.HeldInHand | UnityEngine.XR.InputDeviceCharacteristics.Right | UnityEngine.XR.InputDeviceCharacteristics.Controller;
        UnityEngine.XR.InputDevices.GetDevicesWithCharacteristics(desiredRightCharacteristics, rightHandedControllers);

        //foreach (var device in rightHandedControllers)
        //{
        //    Debug.Log(string.Format("Device name '{0}' has characteristics '{1}'", device.name, device.characteristics.ToString()));
        //}

        if (rightHandedControllers.Count > 0)
        {
            rightController = rightHandedControllers[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
