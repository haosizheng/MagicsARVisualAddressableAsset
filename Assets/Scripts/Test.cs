using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;


public class Test : MonoBehaviour
{
    [SerializeField] GameObject Container;

    [SerializeField] string addressableIP;
    [SerializeField] AssetReference addressableRef;

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
            Addressables.LoadAssetAsync<GameObject>(addressableIP).Completed += OnLoadDoneWithIP;
        }

        if (LoadWithRef)
        {
            LoadWithRef = false;
            // load with refenerce
            Addressables.LoadAssetAsync<GameObject>(addressableRef).Completed += OnLoadDoneWithRef;
        }


    }

    private void OnLoadDoneWithIP(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> obj)
    {
        // In a production environment, you should add exception handling to catch scenarios such as a null result
        var go = obj.Result;
        GameObject.Instantiate(go);
    }

    private void OnLoadDoneWithRef(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> obj)
    {
        // In a production environment, you should add exception handling to catch scenarios such as a null result
        var go = obj.Result;
        GameObject.Instantiate(go);

    }


}