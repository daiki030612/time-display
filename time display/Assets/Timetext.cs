using UnityEngine;
using TMPro; // TextMeshProを使う場合
using System;

public class Timetext : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI DateTimeText;

    void Update()
    {
        // DateTimeTextがnullでないかチェック
        if (DateTimeText == null)
        {
            Debug.LogError("DateTimeText が設定されていません。Inspectorで TextMeshPro コンポーネントを設定してください。");
            return;
        }

        DateTime now = DateTime.Now;
        DateTimeText.text = now.ToString("yyyy年MM月dd日 HH:mm:ss");
    }
}
