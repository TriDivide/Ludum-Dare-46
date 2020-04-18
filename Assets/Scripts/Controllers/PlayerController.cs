using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    private float mouseSpeed = 3f;

    [SerializeField]
    private Camera cam;

    private Vector3 velocity = Vector3.zero;
    private Vector3 rotation = Vector3.zero;
    private Vector3 tilt = Vector3.zero;

    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        float xMovement = Input.GetAxisRaw("Horizontal");
        float zMovement = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * xMovement;
        Vector3 moveVertical = transform.forward * zMovement;

        Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed;
    }

    
}
