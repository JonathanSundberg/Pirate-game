using Unity.Entities;
[GenerateAuthoringComponent]
[InternalBufferCapacity(10)]
public struct SpawnablePrefabBuffer : IBufferElementData
{
    public Entity prefab;
}
