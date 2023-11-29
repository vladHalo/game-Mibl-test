using Core.Scripts.Interfaces;
using Core.Scripts.Player.Models;

namespace Core.Scripts.Player.States
{
    public class DeadState : IState
    {
        private readonly PlayerStateManager _player;

        private readonly DeadModel _deadModel;

        public DeadState(PlayerStateManager player, DeadModel deadModel)
        {
            _player = player;
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