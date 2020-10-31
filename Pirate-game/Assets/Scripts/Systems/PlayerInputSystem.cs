using Unity.Entities;
using UnityEngine;
using System;

public class PlayerInputSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref PlayerComponent playerComponent) =>
        {
            bool isRightKeyPressed = Input.GetKey(playerComponent.right);
            bool isLeftKeyPressed = Input.GetKey(playerComponent.left);
            bool isUpKeyPressed = Input.GetKey(playerComponent.up);
            bool isDownKeyPressed = Input.GetKey(playerComponent.down);

            playerComponent.direction.x = Convert.ToInt32(isRightKeyPressed);
            playerComponent.direction.x -= Convert.ToInt32(isLeftKeyPressed);
            playerComponent.direction.z = Convert.ToInt32(isUpKeyPressed);
            playerComponent.direction.z -= Convert.ToInt32(isDownKeyPressed);

        }).Run();
    }
}
