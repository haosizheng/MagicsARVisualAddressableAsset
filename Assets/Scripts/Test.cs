using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;


public class Test : MonoBehaviour
{
    [SerializeField] GameObject myGameObject;
    [SerializeField] AssetReference addressableAsset;
    public bool LoadWithIP;
    public bool LoadWithRef;

    private void Start()
    {


    }

    private void Update()
    {
        if (LoadWithIP)
        {
            LoadWithIP = false;
            // load with ip address
            Addressables.LoadAssetAsync<GameObject>("Capsule").Completed += OnLoadDoneWithIP;
        }

        if (LoadWithRef)
        {
            LoadWithRef = false;
            // load with refenerce
            Addressables.LoadAssetAsync<GameObject>(addressableAsset).Completed += OnLoadDoneWithRef;
        }


    }

    private void OnLoadDoneWithIP(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> obj)
    {
        // In a production environment, you should add exception handling to catch scenarios such as a null result
        myGameObject = obj.Result;
    }

    private void OnLoadDoneWithRef(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> obj)
    {
        // In a production environment, you should add exception handling to catch scenarios such as a null result
        myGameObject = obj.Result;
    }


}