using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillItem_02 : MonoBehaviour
{
    public KeyCode keyCode;
    public float coldTime = 2.0f;
    private float timer = 0;
    private Image filledImage;
    private bool isStartTimer = false; 

    // Start is called before the first frame update
    void Start()
    {
        filledImage = transform.Find("FilledImage").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            isStartTimer = true;
        }

        if (isStartTimer)
        {
            timer += Time.deltaTime;
            filledImage.fillAmount = (coldTime - timer) / coldTime;
            if (timer >= coldTime)
            {
                filledImage.fillAmount = 0;
                timer = 0;
                isStartTimer = false;
            }
        }
    }

    public void OnClick()
    {
        isStartTimer = true;
    }
}
