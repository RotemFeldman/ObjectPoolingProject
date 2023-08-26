using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [SerializeField] GameObject poolGameObject;
    [SerializeField] GameObject poolFolder;

    public List<GameObject> poolList;

    public static ObjectPooler instance;

    const int poolSize = 10;
    const string warning = "Pool Game Object is not defined in inspector!";


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        InstantiatePool();
    }

    void InstantiatePool()
    {

        for (int i = 0; i < poolSize; i++)
        {
            GameObject g = Instantiate(poolGameObject,poolFolder.transform);
            
            g.SetActive(false);
            poolList.Add(g);
        }
    }

    public GameObject GetObjectFromPool()
    {
        for (int i = 0;i < poolSize;i++)
        {
            if (!poolList[i].activeInHierarchy)
            {
                return poolList[i];
            }
        }

        return null;
    }


    private void OnValidate()
    {
        if (poolGameObject == null) 
        {
            Debug.LogWarning(warning);
        }
    }


}
