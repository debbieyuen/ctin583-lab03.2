using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    Rigidbody myRigidbody;
    Collider myCollider;
    Light myLight;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody>();
        myCollider = gameObject.GetComponent<Collider>();
        myLight = gameObject.GetComponent<Light>();

        // Color
        myLight.color = Color.green;

        //Intensity
        myLight.intensity = 1.2f;

        // “Mode”
        myLight.lightmapBakeType = LightmapBakeType.Realtime;

        // “Indirect Multiplier”
        myLight.bounceIntensity = 0.8f;

        // “Shadow Type”
        myLight.shadows = LightShadows.Soft;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            // do stuff
            myLight.enabled = false;
        }

    }
}
