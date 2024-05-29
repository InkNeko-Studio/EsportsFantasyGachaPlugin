using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Prize")]
public class Prize : ScriptableObject
{
    public string name;
    public Sprite image;
}
    
[Serializable]
public class GachaItem
{
    public float percentage;
    public Prize prize;
}