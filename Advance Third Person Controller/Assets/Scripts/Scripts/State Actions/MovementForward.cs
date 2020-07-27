using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Action/State Actions/Movement Forward")]
    public class MovementForward : StateActions
    {
        public float movementSpeed = 2;
        public override void Execute(StateManager states)
        {
            if(states.movementVariables.moveAmount > 0.1f)
            {
                states.rigidbody.drag = 0;
            }
            else
            {
                states.rigidbody.drag = 4;
            }
            Vector3 targetVelocity = states.mTransform.forward * states.movementVariables.moveAmount;
            targetVelocity.y = states.rigidbody.velocity.y;
            states.rigidbody.velocity = targetVelocity;
        }

        
    }


}