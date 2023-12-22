using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float idleSpeed = 1f;
    public float walkSpeed = 5f;
    public float runSpeed = 10f;
    public float attackSpeed = 8f;
    public bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down * 0.1f);
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 cameraMovement = new Vector3(horizontalMovement, 0f, verticalMovement).normalized;
        if (Input.GetKeyDown(KeyCode.W))
        {
            walkSpeed = 0f;
        }
    }
    
}
