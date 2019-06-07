using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScores : MonoBehaviour {

    public Text Name1;
    public Text Score1;
    public Text Name2;
    public Text Score2;
    public Text Name3;
    public Text Score3;
    public Button Menu;
    public Button L1Button;
    public Button L2Button;
    public Button L3Button;
    public Button L4Button;
    public Button L5Button;
    public Button L6Button;
    public Button L7Button;
    public int ScoreCount1;
    public int ScoreCount2;
    public int ScoreCount3;
    public string NameRecord1;
    public string NameRecord2;
    public string NameRecord3;

    // Use this for initialization
    void Start () {
        Menu.onClick.AddListener(MenuClick);
        L1Button.onClick.AddListener(L1Click);
        L2Button.onClick.AddListener(L2Click);
        L3Button.onClick.AddListener(L3Click);
        L4Button.onClick.AddListener(L4Click);
        L5Button.onClick.AddListener(L5Click);
        L6Button.onClick.AddListener(L6Click);
        L7Button.onClick.AddListener(L7Click);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void MenuClick()
    {
        SceneManager.LoadScene("Menu");
    }
    void L1Click()
    {
        NameRecord1 = PlayerPrefs.GetString("Lv1Name1");
        Name1.text = NameRecord1 + ":";
        ScoreCount1 = PlayerPrefs.GetInt("Lv1Score1");
        Score1.text = "" + ScoreCount1;
        NameRecord2 = PlayerPrefs.GetString("Lv1Name2");
        Name2.text = NameRecord2 + ":";
        ScoreCount2 = PlayerPrefs.GetInt("Lv1Score2");
        Score2.text = "" + ScoreCount2;
        NameRecord3 = PlayerPrefs.GetString("Lv1Name3");
        Name3.text = NameRecord3 + ":";
        ScoreCount3 = PlayerPrefs.GetInt("Lv1Score3");
        Score3.text = "" + ScoreCount3;
    }
    void L2Click()
    {
        NameRecord1 = PlayerPrefs.GetString("Lv2Name1");
        Name1.text = NameRecord1 + ":";
        ScoreCount1 = PlayerPrefs.GetInt("Lv2Score1");
        Score1.text = "" + ScoreCount1;
        NameRecord2 = PlayerPrefs.GetString("Lv2Name2");
        Name2.text = NameRecord2 + ":";
        ScoreCount2 = PlayerPrefs.GetInt("Lv2Score2");
        Score2.text = "" + ScoreCount2;
        NameRecord3 = PlayerPrefs.GetString("Lv2Name3");
        Name3.text = NameRecord3 + ":";
        ScoreCount3 = PlayerPrefs.GetInt("Lv2Score3");
        Score3.text = "" + ScoreCount3;
    }
    void L3Click()
    {
        NameRecord1 = PlayerPrefs.GetString("Lv3Name1");
        Name1.text = NameRecord1 + ":";
        ScoreCount1 = PlayerPrefs.GetInt("Lv3Score1");
        Score1.text = "" + ScoreCount1;
        NameRecord2 = PlayerPrefs.GetString("Lv3Name2");
        Name2.text = NameRecord2 + ":";
        ScoreCount2 = PlayerPrefs.GetInt("Lv3Score2");
        Score2.text = "" + ScoreCount2;
        NameRecord3 = PlayerPrefs.GetString("Lv3Name3");
        Name3.text = NameRecord3 + ":";
        ScoreCount3 = PlayerPrefs.GetInt("Lv3Score3");
        Score3.text = "" + ScoreCount3;
    }
    void L4Click()
    {
        NameRecord1 = PlayerPrefs.GetString("Lv4Name1");
        Name1.text = NameRecord1 + ":";
        ScoreCount1 = PlayerPrefs.GetInt("Lv4Score1");
        Score1.text = "" + ScoreCount1;
        NameRecord2 = PlayerPrefs.GetString("Lv4Name2");
        Name2.text = NameRecord2 + ":";
        ScoreCount2 = PlayerPrefs.GetInt("Lv4Score2");
        Score2.text = "" + ScoreCount2;
        NameRecord3 = PlayerPrefs.GetString("Lv4Name3");
        Name3.text = NameRecord3 + ":";
        ScoreCount3 = PlayerPrefs.GetInt("Lv4Score3");
        Score3.text = "" + ScoreCount3;
    }
    void L5Click()
    {
        NameRecord1 = PlayerPrefs.GetString("Lv5Name1");
        Name1.text = NameRecord1 + ":";
        ScoreCount1 = PlayerPrefs.GetInt("Lv5Score1");
        Score1.text = "" + ScoreCount1;
        NameRecord2 = PlayerPrefs.GetString("Lv5Name2");
        Name2.text = NameRecord2 + ":";
        ScoreCount2 = PlayerPrefs.GetInt("Lv5Score2");
        Score2.text = "" + ScoreCount2;
        NameRecord3 = PlayerPrefs.GetString("Lv5Name3");
        Name3.text = NameRecord3 + ":";
        ScoreCount3 = PlayerPrefs.GetInt("Lv5Score3");
        Score3.text = "" + ScoreCount3;
    }
    void L6Click()
    {
        NameRecord1 = PlayerPrefs.GetString("Lv6Name1");
        Name1.text = NameRecord1 + ":";
        ScoreCount1 = PlayerPrefs.GetInt("Lv6Score1");
        Score1.text = "" + ScoreCount1;
        NameRecord2 = PlayerPrefs.GetString("Lv6Name2");
        Name2.text = NameRecord2 + ":";
        ScoreCount2 = PlayerPrefs.GetInt("Lv6Score2");
        Score2.text = "" + ScoreCount2;
        NameRecord3 = PlayerPrefs.GetString("Lv6Name3");
        Name3.text = NameRecord3 + ":";
        ScoreCount3 = PlayerPrefs.GetInt("Lv6Score3");
        Score3.text = "" + ScoreCount3;
    }
    void L7Click()
    {
        NameRecord1 = PlayerPrefs.GetString("Lv7Name1");
        Name1.text = NameRecord1 + ":";
        ScoreCount1 = PlayerPrefs.GetInt("Lv7Score1");
        Score1.text = "" + ScoreCount1;
        NameRecord2 = PlayerPrefs.GetString("Lv7Name2");
        Name2.text = NameRecord2 + ":";
        ScoreCount2 = PlayerPrefs.GetInt("Lv7Score2");
        Score2.text = "" + ScoreCount2;
        NameRecord3 = PlayerPrefs.GetString("Lv7Name3");
        Name3.text = NameRecord3 + ":";
        ScoreCount3 = PlayerPrefs.GetInt("Lv7Score3");
        Score3.text = "" + ScoreCount3;
    }
}
