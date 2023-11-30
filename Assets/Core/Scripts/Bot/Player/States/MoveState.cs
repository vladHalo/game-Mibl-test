using Core.Scripts.Interfaces;
using Core.Scripts.Bot.Player.Models;
using Core.Scripts.Bot.Zombie;
using Core.Scripts.FactoryBomb;
using UnityEngine;

namespace Core.Scripts.Bot.Player.States
{
    public class MoveState : IStatePlayer
    {
        private readonly PlayerStateManager _player;

        private readonly Bot _bot;
        private readonly MoveModel _moveModel;

        public MoveState(PlayerStateManager player, Bot bot, MoveModel moveModel)
        {
            _player = player;
            _bot = bot;
            _moveModel = moveModel;
        }

        public void EnterState()
        {
            _bot.IsKinematic(true);
        }

        public void FinishState()
        {
            
        }
        
        public void FixedUpdateState()
        {
            Vector3 moveVector = new Vector3(_moveModel.joystick.Horizontal, 0, _moveModel.joystick.Vertical);
            _bot.rigidbody.velocity = new Vector3(moveVector.x * _moveModel.speed, _bot.rigidbody.velocity.y,
                moveVector.z * _moveModel.speed);

            if (Vector3.Angle(Vector3.forward, moveVector) > 1f || Vector3.Angle(Vector3.forward, moveVector) == 0)
            {
                Vector3 direct = Vector3.RotateTowards(_player.transform.forward,
                    moveVector, _moveModel.speed * 4f * Time.fixedDeltaTime,
                    0.0f);
                _bot.rigidbody.rotation = Quaternion.LookRotation(direct);
            }

            var floatSpeed = _bot.rigidbody.velocity.magnitude / _moveModel.speed;
            _bot.animator.SetFloat(Str.SpeedPlayer, floatSpeed);
        }

        public void OnCollisionState(Collision other)
        {
            if (other.gameObject.TryGetComponent(out ZombieStateManager zombie))
            {
                _player.SetState(_player.deadState);
            }
        }
    }
}