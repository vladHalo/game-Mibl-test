using Core.Scripts.Interfaces;
using Core.Scripts.Player.Models;

namespace Core.Scripts.Player.States
{
    public class MoveState : IState
    {
        private readonly PlayerStateManager _player;

        private readonly MoveModel _moveModel;

        public MoveState(PlayerStateManager player, MoveModel moveModel)
        {
            _player = player;
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