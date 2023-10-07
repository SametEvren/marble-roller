using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    public List<Pool> pools;
    public Dictionary<string, Queue<GameObject>> poolDictionary;
    public List<GameObject> poolOrderBottom = new List<GameObject>();
    public List<GameObject> poolOrderTop = new List<GameObject>();
    public List<GameObject> poolOrderObstacle = new List<GameObject>();
    public List<GameObject> poolOrderGold = new List<GameObject>();

    #region Singleton
    public static ObjectPooler Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();
        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();
            
            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);                
            }

            poolDictionary.Add(pool.tag, objectPool);

            //Debug.Log(pool.tag);
        }
    }

    public GameObject SpawnFromPoolBottom (string tag, Vector3 position, Quaternion rotation)
    {
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool with [" + tag + "] tag doesn't exist");
            return null;
        }
        
        GameObject objectToSpawn = poolDictionary[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;
        poolOrderBottom.Clear();
        poolOrderBottom.Add(objectToSpawn);        
        poolDictionary[tag].Enqueue(objectToSpawn);
        
        return objectToSpawn;
    } 
    public GameObject SpawnFromPoolTop (string tag, Vector3 position, Quaternion rotation)
    {
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool with [" + tag + "] tag doesn't exist");
            return null;
        }
        
        GameObject objectToSpawn = poolDictionary[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;
        poolOrderTop.Clear();
        poolOrderTop.Add(objectToSpawn);        
        poolDictionary[tag].Enqueue(objectToSpawn);
        
        return objectToSpawn;
    }
    public GameObject SpawnFromPoolObstacle (string tag, Vector3 position, Quaternion rotation)
    {
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool with [" + tag + "] tag doesn't exist");
            return null;
        }
        
        GameObject objectToSpawn = poolDictionary[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;
        poolOrderObstacle.Clear();
        poolOrderObstacle.Add(objectToSpawn);                
        poolDictionary[tag].Enqueue(objectToSpawn);
        
        return objectToSpawn;
    }
    public GameObject SpawnFromPoolCoin (string tag, Vector3 position, Quaternion rotation)
    {
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool with [" + tag + "] tag doesn't exist");
            return null;
        }
        
        GameObject objectToSpawn = poolDictionary[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;
        poolOrderGold.Clear();
        poolOrderGold.Add(objectToSpawn);                
        poolDictionary[tag].Enqueue(objectToSpawn);
        
        return objectToSpawn;
    }
    
}
