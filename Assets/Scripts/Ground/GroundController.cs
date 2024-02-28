using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ground", menuName = "Contoller/Ground")]

public class GroundController : ScriptableObject
{
    [SerializeField] private Tile[] _tiles;
    [SerializeField] private TileBehaviour _tileObj;
    [SerializeField] private VoidEvent _onGameStart;

    private Transform _ground;
    private const int _sideNumber = 4;

    private void OnEnable()
    {
        _onGameStart.OnEventRaise += FindGround;
        _onGameStart.OnEventRaise += GenerateGround;
    }
    private void OnDisable ()
    {
        _onGameStart.OnEventRaise -= FindGround;
        _onGameStart.OnEventRaise -= GenerateGround;
    }

    private void FindGround()
    {
        _ground = GameObject.FindGameObjectWithTag("Ground").transform;
    }

    private void GenerateGround()
    {
        float pvot = _tileObj.gameObject.transform.localScale.x / 2;

        for (int i = -4; i < _sideNumber; i++)
        {
            for (int j = -4; j < _sideNumber; j++)
            {
                var obj = Instantiate(_tileObj, _ground);
                obj.transform.position = new Vector3(j + pvot, i + pvot, 0);
                Color32 color = (((i+j)%2) == 0) ? _tiles[0].BaseColor : _tiles[0].OffsetColor; 
                obj.SetColor(color);
            }
        }
    }
}
