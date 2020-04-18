using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerItemColisionController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "ItemFragmentPickup") {
            pickupFragment(other.gameObject);
        } 
    }

    private void pickupFragment(GameObject fragment) {
        Debug.Log("Touched the fragment");
    }

}
