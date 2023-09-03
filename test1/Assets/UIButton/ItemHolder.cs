using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ItemHolder : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Item _item;

    private void Start()
    {
        _image.sprite = _item.SpriteObject;
    }
}
