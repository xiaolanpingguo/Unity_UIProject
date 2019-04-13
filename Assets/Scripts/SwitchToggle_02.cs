using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchToggle_02 : MonoBehaviour
{
    public GameObject switchOnGameObject;
    public GameObject switchOffGameObject;
    private Toggle toggle;

    // Start is called before the first frame update
    void Start()
    {
        toggle = GetComponent<Toggle>();
        OnValueChanged(toggle.isOn);
    }

    public void OnValueChanged(bool isOn)
    {
        switchOnGameObject.SetActive(isOn);
        switchOffGameObject.SetActive(!isOn);
    }
}
