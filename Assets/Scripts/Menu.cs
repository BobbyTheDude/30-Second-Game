using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int MazeChoice;
    private void Start()
    {
        MazeChoice = Random.Range(1, 4);
    }
    public void Play()
    {
        if (MazeChoice == 1)
        {
            SceneManager.LoadScene("Maze1");
        }
        if (MazeChoice == 2)
        {
            SceneManager.LoadScene("Maze2");
        }
        if (MazeChoice == 3)
        {
            SceneManager.LoadScene("Maze3");
        }
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
