using System.Collections;
using UnityEngine;
using Zenject;

namespace Core.Scripts.FactoryBomb
{
    public class FactoryBomb : MonoBehaviour
    {
        [SerializeField] private Factory _factoryBomb;
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
                    _factoryBomb.Create<Bomb>(Vector3.zero);
                }

                yield return new WaitForSeconds(Random.Range(_minDelay, _maxDelay));
            }
        }
    }
}