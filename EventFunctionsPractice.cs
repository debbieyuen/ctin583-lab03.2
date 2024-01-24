using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventFunctionsPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start called.");
    }

    private void Awake()
    {
        Debug.Log("Awake called.");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable called.");
    }

        private void OnDisable)
    {
        Debug.Log("OnDisable called.");
    }

    // Called every physics step. Intervals are consistent
    // Used for regular updates and adjusting physics
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }

}
