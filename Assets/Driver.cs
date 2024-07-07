using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float driveSpeed = 18.5f;
    [SerializeField] float slowDriveSpeed = 10.5f;
    [SerializeField] float fastDriveSpeed = 30f;
    [SerializeField] float defaultSpeed = 18.5f;
    [SerializeField] float boosterDestroyDelay = 0.5f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float driveAmount = Input.GetAxis("Vertical") * driveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, driveAmount, 0);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        driveSpeed = slowDriveSpeed;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && driveSpeed == slowDriveSpeed)
        {
            driveSpeed = defaultSpeed;
        }
        else if (other.tag == "Boost" && driveSpeed != fastDriveSpeed)
        {
            Debug.Log("Booster equipped!!");
            driveSpeed = fastDriveSpeed;
            Destroy(other.gameObject, boosterDestroyDelay);
        }
    }
}