﻿using UnityEngine;
using UnityEngine.UI;
public class CoinText : MonoBehaviour
{
    Text _text;
    private void OnEnable()
    {
        _text = GetComponent<Text>();
        GameManager.Instance.OnCollectCoin += ShowNumberOfCoins;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnCollectCoin -= ShowNumberOfCoins;
    }
    void ShowNumberOfCoins(int count)
    {
        _text.text = "x" + count;
    }
}