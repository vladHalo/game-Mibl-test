using Core.Scripts.Interfaces;
using Core.Scripts.Zombie.Models;

namespace Core.Scripts.Zombie.States
{
    public class MoveState : IState
    {
        private readonly ZombieStateManager _zombie;

        private readonly MoveModel _moveModel;

        public MoveState(ZombieStateManager zombie, MoveModel moveModel)
        {
            _zombie = zombie;
            _moveModel = moveModel;
        }

        public void EnterState()
        {
        }

        public void UpdateState()
        {
        }
    }
}