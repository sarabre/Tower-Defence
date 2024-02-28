using UnityEngine;

[CreateAssetMenu(fileName ="Tile",menuName = "Ground/Tile")]

public abstract class Tile : ScriptableObject
{
    public Color32 BaseColor, OffsetColor;
}
