using System.Collections;
using Core.Scripts.Interfaces;
using Core.Scripts.Bot.Player.Models;
using Core.Scripts.Enums;
using Sirenix.Utilities;
using UnityEngine;

namespace Core.Scripts.Bot.Player.States
{
    public class DeadState : IStatePlayer
    {
        private readonly PlayerStateManager _player;

        private readonly Bot _bot;
        private readonly DeadModel _deadModel;

        public DeadState(PlayerStateManager player, Bot bot, DeadModel deadModel)
        {
            _player = player;
            _bot = bot;
            _deadModel = deadModel;
        }

        public void EnterState()
        {
            AudioManager.instance.PlaySoundEffect(SoundType.DeadMan);
            _bot.Dead();
            _player.gameManager.ChangeStatusGame(StatusGame.Stop);
            _player.StartCoroutine(Lose());
        }

        public void FinishState()
        {
        }

        public void FixedUpdateState()
        {
        }

        public void OnCollisionState(Collision other)
        {
        }

        public IEnumerator Lose()
        {
            yield return new WaitForSeconds(2);
            _deadModel.actionPanelManager.OpenPanels(0);
        }
    }
}