using Core.Scripts.Interfaces;
using Core.Scripts.Zombie.Models;

namespace Core.Scripts.Zombie.States
{
    public class DeadState : IState
    {
        private readonly ZombieStateManager _zombie;

        private readonly DeadModel _deadModel;

        public DeadState(ZombieStateManager zombie, DeadModel deadModel)
        {
            _zombie = zombie;
            _deadModel = deadModel;
        }

        public void EnterState()
        {
        }

        public void UpdateState()
        {
        }
    }
}