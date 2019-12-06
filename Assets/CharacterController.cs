using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float speed;
    public float jump;

    Rigidbody rb;
    Vector3 initPos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(Vector3.forward * speed);
        if (Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(Vector3.back * speed);
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(Vector3.left * speed);
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(Vector3.right * speed);
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < 1.5)
            rb.AddForce(Vector3.up * jump);
        if (transform.position.y < 0)
            transform.position = initPos;
    }
}
