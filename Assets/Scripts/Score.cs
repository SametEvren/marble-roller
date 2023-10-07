using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    #region Singleton

    public static Score instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    #endregion
    public TextMeshProUGUI score;
    public float time = 0;
    private void Update()
    {
        time += Time.deltaTime * 2;
        score.text = (Convert.ToInt32(time)).ToString();
    }


}
