using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // setting the camera so it follows the car 
    [SerializeField] GameObject carToFollow;
    void LateUpdate()
    {
        transform.position = carToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
