using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PaperDollSceneManager : MonoBehaviour
{
    [field: SerializeField]
    public ItemData CurrentItem { get; private set; }
    [field: SerializeField]
    public SpriteRenderer ArmorSprite { get; private set; }
    [field: SerializeField]
    public TextMeshProUGUI ItemName { get; private set; }
    [field: SerializeField]
    public TextMeshProUGUI ItemCost { get; private set; }
    [field: SerializeField]
    public TextMeshProUGUI ItemDescription { get; private set; }

    void Start()
    {
        SetCurrentItem(CurrentItem);
    }

    public void SetCurrentItem(ItemData data)
    {
        CurrentItem = data;
        ArmorSprite.sprite = data.Sprite;
        ItemName.text = data.Name;
        ItemCost.text = $"Cost: {data.Cost} Gold";
        ItemDescription.text = data.Description;
    }

}
