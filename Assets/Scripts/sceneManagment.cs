using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManagment : MonoBehaviour {

    public void lvlOne()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
    }

    public void lvlTwo()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
    }

    public void lvlThree()
    {
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1;
    }

    public void lvlFour()
    {
        SceneManager.LoadScene("Level4");
        Time.timeScale = 1;
    }

    public void lvlFive()
    {
        SceneManager.LoadScene("Level5");
        Time.timeScale = 1;
    }

    public void lvlSix()
    {
        SceneManager.LoadScene("Level6");
        Time.timeScale = 1;
    }

    public void lvlSeven()
    {
        SceneManager.LoadScene("Level7");
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void reload()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
    }
}
