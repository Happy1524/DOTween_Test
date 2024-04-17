using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Text : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RectTransform rt = GetComponent<RectTransform>();
        rt.DOAnchorPosY(-120, 1).SetDelay(1.5f);
    }
}
