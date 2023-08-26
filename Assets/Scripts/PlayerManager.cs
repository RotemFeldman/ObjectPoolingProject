using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        { 
            Fire();         
        }
    }

    private void Fire()
    {
        GameObject bullet = ObjectPooler.instance.GetObjectFromPool();

        if (bullet != null )
        {
            bullet.transform.localPosition = Vector3.zero;
            bullet.SetActive(true);
        }
    }
}
