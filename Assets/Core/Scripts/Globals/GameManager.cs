using Core.Scripts.Enums;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform player;
    public StatusGame statusGame;

    public void ChangeStatusGame(StatusGame status) => statusGame = status;
}