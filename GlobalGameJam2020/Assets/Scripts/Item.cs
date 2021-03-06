﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Item", menuName = "Items")]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemImg;
}
