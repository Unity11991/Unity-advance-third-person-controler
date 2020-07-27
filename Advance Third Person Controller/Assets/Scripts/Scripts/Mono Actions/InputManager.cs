using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SO;



namespace SA
{
    [CreateAssetMenu(menuName = "Actions/Mono Actions/Input Manager")]
    public class InputManager : Action
    {
        public FloatVariable horizontal;
        public FloatVariable vertical;

        public StateManagerVariable playerState;
        public ActionBatch inputUpdateBatch;
        public override void Execute()
        {
            inputUpdateBatch.Execute();
            if(playerState.value != null)
            {
                playerState.value.movementVariables.horizontal = horizontal.value;
                playerState.value.movementVariables.vertical = vertical.value;

                float moveAmount = Mathf.Clamp01(Mathf.Abs(horizontal.value) + Mathf.Abs(vertical.value));
                playerState.value.movementVariables.moveAmount = moveAmount; 

            }
        }

    }
}
