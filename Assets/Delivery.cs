using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyPackageDelay = 0.5f;
    bool hasPackage = false;
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Boom!");
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            Destroy(other.gameObject, destroyPackageDelay);
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered package");
            hasPackage = false;
        }
    }
}
