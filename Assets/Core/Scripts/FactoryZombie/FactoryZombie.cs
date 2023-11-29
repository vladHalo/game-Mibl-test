using System.Collections;
using Core.Scripts.Zombie;
using UnityEngine;
using Zenject;

namespace Core.Scripts.FactoryZombie
{
    public class FactoryZombie : MonoBehaviour
    {
        public bool withoutPower;
        
        [SerializeField] private Factory _factoryZombie;
        [SerializeField] private float _minDelay, _maxDelay;

        [Inject] private GameManager _gameManager;

        private void Start()
        {
            StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                if (_gameManager.statusGame == StatusGame.Play)
                {
                    _factoryZombie.Create<ZombieStateManager>(Vector3.zero);
                }
                yield return new WaitForSeconds(Random.Range(_minDelay, _maxDelay));
            }
        }
    }
}