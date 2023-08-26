using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{    
    [SerializeField] float speed = 10f;

    float timeAlive;

    const float setTimeAlive = 5f;


    void Update()
    {
        if (timeAlive > 0)
        {
            timeAlive -= Time.deltaTime;
            gameObject.transform.Translate(0, 0, speed * Time.deltaTime);
        }
        else
        {
            gameObject.SetActive(false);
            
            timeAlive = setTimeAlive;
        }
    }
}
