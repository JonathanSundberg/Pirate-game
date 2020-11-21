using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IslandSpawnerMono : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefabs;

    private int max_islands = 3;
    private int islands_count = 0;

    private float min_spawn_time = 0;
    private float max_spawn_time = 0.01f;

    private float spawntime = 0;
    private int nr_of_prefabs = 0;
    private float time = 0;

    private void Start()
    {
        spawntime = get_new_spawn_time();
        nr_of_prefabs = prefabs.Length;
        Debug.Log(nr_of_prefabs);
    }
    // Update is called once per frame
    void Update()
    {
        if (islands_count < max_islands)
        {
            time += Time.deltaTime;
            if (time >= spawntime)
            {
                spawn_island();
                spawntime = get_new_spawn_time();
                
                time = 0;

            }
        }
        
    }

    void spawn_island()
    {
        int random_index = Random.Range(0, nr_of_prefabs);
        Debug.Log(random_index);
        Instantiate(prefabs[random_index], get_spawn_position(), Quaternion.identity);
    }

    float get_new_spawn_time()
    {
        return Random.Range(min_spawn_time, max_spawn_time);
    }

    Vector3 get_spawn_position()
    {
        float x = Random.Range(-22, 22);
        float z = -x *1.59f;
         Vector3 spawn_pos = new Vector3(x+40, 0, z+40);
        return spawn_pos;
    }
        
}
