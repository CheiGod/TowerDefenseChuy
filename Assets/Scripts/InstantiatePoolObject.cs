using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.Pool;

public class InstantiatePoolObject : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab;
    [SerializeField]
    private Transform _parent;
    private List<GameObject> _pool = new List<GameObject>();
    public void InstantiateObject(Transform target)
    {
        GameObject obj = GetPooledObject();
        if (obj != null)
        {
            obj.transform.position = target.position;
            obj.transform.rotation = target.rotation;
            obj.SetActive(true);
        }
    }
    public void PositionObject(GameObject obj, Vector3 position, quaternion rotation)
    {
        if (_parent != null)
        {
            obj.transform.SetParent(_parent, false);
            obj.transform.SetLocalPositionAndRotation(position, rotation);
        }
        else
        {
            obj.transform.SetPositionAndRotation(position, rotation);
        }
        obj.SetActive(true);
    }
    private GameObject GetPooledObject()
    {
        GameObject obj = null;
        obj = _pool.Find(x => !x.activeInHierarchy);
        if (obj == null)
        {

        }
        else
        {
            
        }
    }
}
