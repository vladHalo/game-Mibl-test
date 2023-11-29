using Core.Scripts.Interfaces;
using Core.Scripts.Zombie.Models;
using Core.Scripts.Zombie.States;
using UnityEngine;

namespace Core.Scripts.Zombie
{
    public class ZombieStateManager : MonoBehaviour
    {
        public MoveState moveState;
        public DeadState deadState;

        [SerializeField] private MoveModel _moveModel;
        [SerializeField] private DeadModel _deadModel;

        private IState _currentState;

        private void Start()
        {
            moveState = new MoveState(this, _moveModel);
            deadState = new DeadState(this, _deadModel);
            _currentState = moveState;
        }

        private void Update()
        {
            _currentState.UpdateState();
        }

        public void SetState(IState newState)
        {
            _currentState = newState;
            _currentState.EnterState();
        }
    }
}