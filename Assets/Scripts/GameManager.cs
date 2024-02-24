using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    [SerializeField]
    private bool _isGameOver;

    private void Update()
    {
        //if the r key was pressed 
        //restart the current scene
        if (Input.GetKeyDown(KeyCode.R) && _isGameOver == true)
        {
            SceneManager.LoadScene(1); //Current Game Scene
        }
    }
    public void GameOver()
    {
        _isGameOver = true;
    }
}
