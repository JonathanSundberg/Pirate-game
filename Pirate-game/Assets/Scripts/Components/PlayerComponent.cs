using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
[GenerateAuthoringComponent]
public struct PlayerComponent : IComponentData
{
    public float max_move_x;
    public float min_move_x;
    public float max_move_z;
    public float min_move_z;

    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;

    public float3 direction;
    public float speed;

}