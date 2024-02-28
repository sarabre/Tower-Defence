using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private VoidEvent _onGameStart;
    void Start()
    {
        _onGameStart.EventRaise();
    }

}
