﻿using UnityEngine;
using System.Collections;
using SO;

namespace SA
{
    public class OnEnable_AssignStateManager : MonoBehaviour
    {
        public StateManagerVariable targetVariable;
        private void OnEnable()
        {
            targetVariable.value = GetComponent<StateManager>();
            Destroy(this);
        }

    }
} 