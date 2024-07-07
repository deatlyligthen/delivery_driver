using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyPackageDelay = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(36, 255, 0, 255);
    [SerializeField] Color32 noPackageColor = new Color32(0, 128, 128, 255);
    bool hasPackage = false;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
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
            spriteRenderer.color = hasPackageColor;
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered package");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
