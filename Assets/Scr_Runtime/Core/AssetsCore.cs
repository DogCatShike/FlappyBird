using System;
using UnityEngine;
using FB;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.AddressableAssets;

public class AssetsCore
{
    public Dictionary<string, GameObject> entities;
    //AsyncOperationHandle 异步操作句柄，用于跟踪异步加载状态
    public AsyncOperationHandle entitiesHandle;

    public AssetsCore()
    {
        entities = new Dictionary<string, GameObject>();
    }

    public void LoadAll()
    {
        //TODO
    }

    public void UnLoadAll()
    {
        //TODO
    }

    //Entity
    public GameObject Entity_GetPlayer()
    {
        entities.TryGetValue("Entity_Player", out GameObject entity);
        if(entity == null)
        {
            Debug.Log("Entity_Player is null");
        }
        return entity;
    }

    public GameObject Entity_GetPipeline()
    {
        entities.TryGetValue("Entity_Pipeline", out GameObject entity);
        if(entity == null)
        {
            Debug.Log("Entity_Pipeline is null");
        }
        return entity;
    }
}