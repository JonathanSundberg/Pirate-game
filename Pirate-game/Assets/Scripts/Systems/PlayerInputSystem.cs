using Unity.Entities;
using UnityEngine;
using Unity.Transforms;
using System;

public class PlayerInputSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref PlayerComponent playerComponent, ref Translation pos) =>
        {
            bool isLeftKeyPressed   = false;
            bool isUpKeyPressed     = false;
            bool isDownKeyPressed   = false;
            bool isRightKeyPressed  = false;


            if(pos.Value.x <= playerComponent.max_move_x)
            {
                isDownKeyPressed   = Input.GetKey(playerComponent.down);
            }
            if (pos.Value.x >= playerComponent.min_move_x)
            {
                isUpKeyPressed     = Input.GetKey(playerComponent.up);
            }
            if (pos.Value.z >= playerComponent.min_move_z)
            {
                isLeftKeyPressed = Input.GetKey(playerComponent.left);
            }
            if(pos.Value.z <= playerComponent.max_move_z)
            {
                isRightKeyPressed  = Input.GetKey(playerComponent.right);
            }

            playerComponent.direction.x = Convert.ToInt32(isDownKeyPressed);
            playerComponent.direction.x -= Convert.ToInt32(isUpKeyPressed);
            playerComponent.direction.z = Convert.ToInt32(isRightKeyPressed);
            playerComponent.direction.z -= Convert.ToInt32(isLeftKeyPressed);

        }).Run();
    }
}
