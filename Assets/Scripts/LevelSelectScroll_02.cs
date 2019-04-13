using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelSelectScroll_02 : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private ScrollRect scrollRect;
    private float[] pageArray = new float[] { 0, 1.0f };

    public Toggle[] toggleArray;
 
    // 滑动的时候的缓动效果
    private float targetHorizontalPosition = 0;

    private float speed = 4;

    // 是否在拖拽
    private bool isDraging = false;

    // Start is called before the first frame update
    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
    }

    void Update()
    {
        if (!isDraging)
        {
            scrollRect.horizontalNormalizedPosition = Mathf.Lerp(
             scrollRect.horizontalNormalizedPosition, targetHorizontalPosition, Time.deltaTime * speed);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDraging = true;
    }

    public void OnDrag(PointerEventData data)
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDraging = false;

        float posX = scrollRect.horizontalNormalizedPosition;
        int index = 0;
        float offset = Mathf.Abs(pageArray[index] - posX);
        for (int i = 0; i < pageArray.Length; ++i)
        {
            float offsetTmp = Mathf.Abs(pageArray[i] - posX);
            if (offsetTmp < offset)
            {
                index = i;
                offset = offsetTmp;
            }
        }

        targetHorizontalPosition = pageArray[index];
        toggleArray[index].isOn = true;
    }

    public void OnMoveToPage1(bool isOn)
    {
        if (isOn)
        {
            targetHorizontalPosition = pageArray[0];
        }
    }

    public void OnMoveToPage2(bool isOn)
    {
        if (isOn)
        {
            targetHorizontalPosition = pageArray[1];
        }
    }
}
