using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpiderMover : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    //float distance = Vector3.Distance(Player.transform.position, transform.position);

    private void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Player.position);
        //Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        //transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1 * Time.deltaTime);
        //transform.position += transform.forward * 1f * Time.deltaTime;
    }
}
