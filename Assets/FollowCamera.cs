using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //Camera should follow the Driver

    [SerializeField]
    GameObject thingToFollow;

    [SerializeField]
    int distanceFromUpstairs = -10;

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,distanceFromUpstairs);
    }
}
