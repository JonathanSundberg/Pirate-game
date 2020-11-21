using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public class IslandMoverSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;


        Entities.ForEach((ref Translation pos, in IslandComponent island) =>
        {
            float3 direction = new float3(-1, 0, -1);
            pos.Value += direction * island.speed * deltaTime;
        }).Run();
    }
}