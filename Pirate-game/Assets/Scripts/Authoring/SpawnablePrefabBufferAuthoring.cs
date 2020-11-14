using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class SpawnablePrefabBufferAuthoring : MonoBehaviour, IConvertGameObjectToEntity
{
    [SerializeField]
    public Entity[] prefabArray;
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        DynamicBuffer<SpawnablePrefabBuffer> dynamicbuffer = dstManager.AddBuffer<SpawnablePrefabBuffer>(entity);
        foreach(Entity pref in prefabArray)
        {
            dynamicbuffer.Add(new SpawnablePrefabBuffer { prefab = pref });
        }
    }

}
