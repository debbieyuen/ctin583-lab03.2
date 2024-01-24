using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventFunctionsPractice : MonoBehaviour
{
    [SerializeField] private GameObject player;

    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(player, new Vector3(x, 2, z), Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start called.");
        InvokeRepeating("SpawnObject", 2, 1/2);
        CancelInvoke("SpawnObject");
    }

    private void Awake()
    {
        Debug.Log("Awake called.");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable called.");
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
