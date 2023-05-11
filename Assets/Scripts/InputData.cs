using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.XR;

public class InputData : MonoBehaviour
{
    public InputDevice rightController;
    public InputDevice leftController;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //we constantly check if any of our InputDevices are not valid. If they are not, we try to initialize them again.
        if (!rightController.isValid || !leftController.isValid)
        {
            InitializeInputDevices();
        }
    }

    //will go through all our input devices and try to initialize them.
    private void InitializeInputDevices() 
    {
        if (!rightController.isValid)
        {
            InitializeInputDevice(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Right, ref rightController);
        }
        if (!leftController.isValid)
        {
            InitializeInputDevice(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Left, ref leftController);
        }
    }

    //will take InputDeviceCharactestics and try to populate whatever input device is passed into it
    //if it’s able to find a device with those characteristics.
    private void InitializeInputDevice(InputDeviceCharacteristics inputCharacteristics, ref InputDevice inputDevice)
    {
        List<InputDevice> devices = new List<InputDevice>();
        //Call InputDevices to see if it can find any devices with the characteristics we're looking for
        InputDevices.GetDevicesWithCharacteristics(inputCharacteristics, devices);

        //Our hands might not be active and so they will not be generated from the search
        //We check if any devices are found here to avoid errors
        if (devices.Count > 0)
        {
            inputDevice = devices[0];
        }
    }
}

// -same purpose of tracking device input but not working

//using System.Collections;
//using System.Collections.Generic;
//using System.Runtime.CompilerServices;
//using UnityEngine;
//using UnityEngine.InputSystem;
//using UnityEngine.XR;

//public class InputData : MonoBehaviour
//{
//    public UnityEngine.XR.InputDevice leftController;
//    public UnityEngine.XR.InputDevice rightController;

//// Start is called before the first frame update
//    void Start()
//    {

//        //get left hand controller
//        var leftHandedControllers = new List<UnityEngine.XR.InputDevice>();
//        var desiredLeftCharacteristics = UnityEngine.XR.InputDeviceCharacteristics.HeldInHand | UnityEngine.XR.InputDeviceCharacteristics.Left | UnityEngine.XR.InputDeviceCharacteristics.Controller;
//        UnityEngine.XR.InputDevices.GetDevicesWithCharacteristics(desiredLeftCharacteristics, leftHandedControllers);

//        //foreach (var device in leftHandedControllers)
//        //{
//        //    Debug.Log(string.Format("Device name '{0}' has characteristics '{1}'", device.name, device.characteristics.ToString()));
//        //}

//        if (leftHandedControllers.Count > 0)
//        {
//            leftController = leftHandedControllers[0];
//        }

//        //get right hand controller
//        var rightHandedControllers = new List<UnityEngine.XR.InputDevice>();
//        var desiredRightCharacteristics = UnityEngine.XR.InputDeviceCharacteristics.HeldInHand | UnityEngine.XR.InputDeviceCharacteristics.Right | UnityEngine.XR.InputDeviceCharacteristics.Controller;
//        UnityEngine.XR.InputDevices.GetDevicesWithCharacteristics(desiredRightCharacteristics, rightHandedControllers);

//        //foreach (var device in rightHandedControllers)
//        //{
//        //    Debug.Log(string.Format("Device name '{0}' has characteristics '{1}'", device.name, device.characteristics.ToString()));
//        //}

//        if (rightHandedControllers.Count > 0)
//        {
//            rightController = rightHandedControllers[0];
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
