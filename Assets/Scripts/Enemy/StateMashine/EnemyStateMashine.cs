﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace TD
{
    [Serializable]
    public class EnemyStateMashine
    {
        [SerializeField] private List<EnemyState> _states = new List<EnemyState>();

        private int _currentStateIndex = 0;

        public void Init(Enemy enemy)
        {
            foreach (EnemyState state in _states)
            {
                state.Init(this, enemy);
            }
        }

        public void NextState()
        {
            if(_currentStateIndex + 1 < _states.Count)
            {
                _currentStateIndex++;
            }
        }

        public void PreviousState() 
        {
            if (_currentStateIndex - 1 > 0)
            {
                _currentStateIndex--;
            }
        }

        public void Update()
        {
            _states[_currentStateIndex].Tick();
        }
    }
}