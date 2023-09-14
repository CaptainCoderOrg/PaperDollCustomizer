using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Armor Quest/ItemData")]
public class ItemData : ScriptableObject
{
    public string Name;
    public int Cost;
    [TextArea]
    public string Description;
    public Sprite Sprite;

    public string ToJSON()
    {
        return JsonUtility.ToJson(this);
    }
}
