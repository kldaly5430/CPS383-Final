using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public Button L1Button;
    public Button L2Button;
    public Button L3Button;
    public Button L4Button;
    public Button L5Button;
    public Button L6Button;
    public Button L7Button;
    public Button HSButton;
    public int LevelUnlock;

    // Use this for initialization
    void Start () {
      L2Button.interactable = false;
        L3Button.interactable = false;
        L4Button.interactable = false;
        L5Button.interactable = false;
        L6Button.interactable = false;
        L7Button.interactable = false;
        HSButton.onClick.AddListener(HSClick);
        L1Button.onClick.AddListener(L1Click);
        L2Button.onClick.AddListener(L2Click);
        L3Button.onClick.AddListener(L3Click);
        L4Button.onClick.AddListener(L4Click);
        L5Button.onClick.AddListener(L5Click);
        L6Button.onClick.AddListener(L6Click);
        L7Button.onClick.AddListener(L7Click);
        LevelUnlock = PlayerPrefs.GetInt("unlockLevel");
    }
	
	// Update is called once per frame
	void Update () {
		if (LevelUnlock >= 2)
        {
            L2Button.interactable = true;
        }
        if (LevelUnlock >= 3)
        {
            L3Button.interactable = true;
        }
        if (LevelUnlock >= 4)
        {
            L4Button.interactable = true;
        }
        if (LevelUnlock >= 5)
        {
            L5Button.interactable = true;
        }
        if (LevelUnlock >= 6)
        {
            L6Button.interactable = true;
        }
        if (LevelUnlock >= 7)
        {
            L7Button.interactable = true;
        }
    }

    void L1Click()
    {
        SceneManager.LoadScene("Level1");
    }
    void L2Click()
    {
        SceneManager.LoadScene("Level2");
    }
    void L3Click()
    {
        SceneManager.LoadScene("Level3");
    }
    void L4Click()
    {
        SceneManager.LoadScene("Level4");
    }
    void L5Click()
    {
        SceneManager.LoadScene("Level5");
    }
    void L6Click()
    {
        SceneManager.LoadScene("Level6");
    }
    void L7Click()
    {
        SceneManager.LoadScene("Level7");
    }
    void HSClick()
    {
        SceneManager.LoadScene("HighScores");
    }

}
