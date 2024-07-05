using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{ 
    [SerializeField] float steerSpeed = 0.12f;
    [SerializeField] float driveSpeed = 0.01f;
  

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
}