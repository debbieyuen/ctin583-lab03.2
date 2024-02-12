using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslatePlayer : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] Rigidbody rb;
    [SerializeField] Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
  
    }

    private void FixedUpdate()
    {
        movePlayer(movement);
    }

    void movePlayer(Vector3 direction)
    {
        //transform.Translate(direction * speed * Time.deltaTime);
        rb.AddForce(direction * speed);
        //rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
    }
}
