using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SO;
namespace SA
{
    [CreateAssetMenu(menuName = "Action/State Actions/Rotate Based on Cam Orientation")]
    public class RotateBasedOnCameraOrientation : StateActions
    {
        public TransformVariable cameraTransform;
        public float speed = 8;
        public override void Execute(StateManager states)
        {
            if(cameraTransform.value == null)
                return;


            float h = states.movementVariables.horizontal;
            float v = states.movementVariables.vertical;


            Vector3 targetDir = cameraTransform.value.forward * v;
            targetDir += cameraTransform.value.right * h;
            targetDir.Normalize();
            targetDir.y = 0;

            if(targetDir == Vector3.zero)
            {
                targetDir = states.mTransform.forward;
            }

            Quaternion tr = Quaternion.LookRotation(targetDir);
            Quaternion targetRotation = Quaternion.Slerp(states.mTransform.rotation, 
                tr, states.delta * states.movementVariables.moveAmount * speed);

            states.mTransform.rotation = targetRotation;

        }
    }


}