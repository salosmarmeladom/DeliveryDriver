using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    SpriteRenderer sr;

    [SerializeField]
    float destroyDelay = 0.1f;

    [SerializeField]
    Color32 noPackageColor = new Color32(255, 255, 255, 255);  //белый цвет

    [SerializeField]
    Color32 hasPackageColor = new Color32(245, 122, 212, 255);  //розовый цвет

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }


    //врезаемся в объект
    private void OnCollisionEnter2D(Collision2D collisedObject)
    {
        Debug.Log("Space car bumped into smth");
    }

    //пересекаем линию
    private void OnTriggerEnter2D(Collider2D triggeredObject)
    {
        if(triggeredObject.tag == "Package" && !hasPackage)
        {
            Debug.Log("The package is picked up");      
            hasPackage = true;
            Destroy(triggeredObject.gameObject, destroyDelay);
            sr.color = hasPackageColor;
        } else if(triggeredObject.tag == "Customer" && hasPackage)
        {
            Debug.Log("The package is delivered");
            hasPackage = false;
            sr.color = noPackageColor;
        }
    }
}
