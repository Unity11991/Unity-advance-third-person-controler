using UnityEngine;
using System.Collections;

namespace SA
{
    [CreateAssetMenu(menuName = "Actions/Mono Actions/Action Batch")]
    public class ActionBatch : Action
    {
        public Action[] actions;
        public override void Execute()
        {
            for(int i = 0; i < actions.Length; i++)
            {
                actions[i].Execute();
            }
        }

    }
}

