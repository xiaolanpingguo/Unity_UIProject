using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_01 : MonoBehaviour
{
    public void OnStartGame(string name)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(name);
    }
}
