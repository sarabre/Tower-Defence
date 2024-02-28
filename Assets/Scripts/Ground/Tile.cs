using UnityEngine;

[CreateAssetMenu(fileName ="Tile",menuName = "Ground/Tile")]

public class Tile : ScriptableObject
{
    [SerializeField] private Color32 _baseColor, _offsetColor;
}
