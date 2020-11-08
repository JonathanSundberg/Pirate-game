using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public class PlayerMovementSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;

        Entities.ForEach((ref Translation pos, in PlayerComponent player) =>
        {
            float3 normalize_direction = math.normalizesafe(player.direction);
            pos.Value += normalize_direction * player.speed * deltaTime;
        }).Run();
    }
}
