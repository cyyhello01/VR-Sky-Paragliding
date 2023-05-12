using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

[RequireComponent(typeof(InputData))]
public class CameraController : MonoBehaviour
{
    public float windSpeed = 100.0f;
    public float initialSpeed = 1.0f;
    float speed = 5.0f;

    //public GameObject cam;
    private InputData inputData;

    public float Sensitivity
    {
        get { return sensitivity; }
        set { sensitivity = value; }
    }
    [Range(0.1f, 9f)][SerializeField] float sensitivity = 2f;

    Vector2 rotation = Vector2.zero;


    // Start is called before the first frame update
    void Start()
    {
        inputData = GetComponent<InputData>();
        //cam = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputData.leftController.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 turnLeft))
        {
            Debug.Log("left controller is moving");
           
            rotation.x += turnLeft.x * sensitivity;
            var xQuat = Quaternion.AngleAxis(rotation.x, Vector3.up);
            transform.localRotation = xQuat;

        }
        if (inputData.rightController.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 turnRight))
        {
            Debug.Log("right controller is moving");
            if(turnRight.y > 0)//speed up
            {
                initialSpeed += speed;
                Debug.Log("speed up: " + initialSpeed);
            }
            else if (turnRight.y < 0) //slow down
            {
                initialSpeed -= speed;
                Debug.Log("speed up: " + initialSpeed);
            }

        }

        //Move the camera forward, backward
        //Vector3 s = transform.forward * 10 * speed * Time.deltaTime;
        //transform.position += s;
        //Debug.Log("Speed: " + s);

    }
}
