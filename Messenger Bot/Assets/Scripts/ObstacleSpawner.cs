using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

    bool CanSpawn = true; 

    public GameObject[] ObjectTypes;

    List<GameObject> ObjectPool = new List<GameObject>();

    public Transform[] Spawners;

    public float CoolDownduration = 0.3f;

    public List<GameObject> ObjectsPool
    {
        get
        {
            return ObjectPool;
        }
    }

    // Use this for initialization
    void Start ()
    {
        for (int i = 0; i < ObjectTypes.Length; i++)
        {
            for (int j = 0; j < 2; j++)
                ObjectPool.Add(Instantiate(ObjectTypes[i]));
        }
	}

    public void CreateObject(int SpawnIndex)
    {
        if (ObjectPool.Count > 0 && CanSpawn)
        {
            int RandIndex = Random.Range(0, ObjectPool.Count - 1);

            ObjectPool[RandIndex].transform.position = Spawners[SpawnIndex].position;

            ObjectPool[RandIndex].SetActive(true);

            ObjectPool.RemoveAt(RandIndex);

            StartCooldown();
        }
    }

    public void StartCooldown()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        CanSpawn = false;

        yield return new WaitForSeconds(CoolDownduration);

        CanSpawn = true;
    }
}
