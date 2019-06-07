using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class winning : MonoBehaviour
{

    private placeUnit unit;
    private Scene scene;
    public GameObject Menu;
    public Text Score;
    public Text time;
    public Text win;
    public Text lose;
    public GameObject nextLvl;
    public GameObject restart;
    //public int balance;
    public int score;

    public string name;
    public GameObject enterName;
    public GameObject HSPanel;

    // Use this for initialization
    void Start () {
        unit = GetComponent<placeUnit>();
        scene = SceneManager.GetActiveScene();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (unit.fight == true)
        {
            if (GameObject.FindGameObjectsWithTag("Player").Length <= 0)
            {
                Time.timeScale = 0;
                Menu.SetActive(true);
                lose.enabled = true;
                restart.SetActive(true);
                unit.fight = false;
                unit.spawnable = false;

                Score.text = "Score: " + score;
                time.text = "Time: " + unit.min + ":" + unit.sec;

                FindObjectOfType<AudioManager>().Stop("BattleSounds");
                GameObject[] enemy = GameObject.FindGameObjectsWithTag("Enemy");
                foreach (GameObject Enemy in enemy)
                {
                    GameObject.Destroy(Enemy);
                }
            }

            if (GameObject.FindGameObjectsWithTag("Enemy").Length <= 0)
            {
                Time.timeScale = 0;
                Menu.SetActive(true);
                win.enabled = true;
                nextLvl.SetActive(true);
                unit.fight = false;
                unit.spawnable = false;

                int baseScore = 10;
                int fundScore = unit.balance / 10;
                if (unit.min <= 1)
                {
                    score = (baseScore + fundScore) * 5;
                }
                else if (unit.min <= 2)
                {
                    score = (baseScore + fundScore) * 4;
                }
                else if (unit.min <= 3)
                {
                    score = (baseScore + fundScore) * 3;
                }
                else if (unit.min <= 4)
                {
                    score = (baseScore + fundScore) * 2;
                }
                else
                {
                    score = (baseScore + fundScore);
                }

                Score.text = "Score: " + score;
                time.text = "Time: " + unit.min + ":" + unit.sec;

                FindObjectOfType<AudioManager>().Stop("BattleSounds");
                GameObject[] enemy = GameObject.FindGameObjectsWithTag("Player");
                foreach (GameObject Enemy in enemy)
                {
                    GameObject.Destroy(Enemy);
                }
                if (scene.name == "Level1")
                {
                    PlayerPrefs.SetInt("unlockLevel", 2);
                    int firstPlace = PlayerPrefs.GetInt("Lv1Score1");
                    int secondPlace = PlayerPrefs.GetInt("Lv1Score2");
                    int thirdPlace = PlayerPrefs.GetInt("Lv1Score3");

                
                    if (score > firstPlace)
                    {
                        HSPanel.SetActive(true);


                    }
                    else if (score > secondPlace)
                    {
                        HSPanel.SetActive(true);
                       
                    }
                    else if (score > thirdPlace)
                    {
                        HSPanel.SetActive(true);
                       
                    }
                }

                //--------------------------------------------------------------
                if (scene.name == "Level2")
                {
                    PlayerPrefs.SetInt("unlockLevel", 3);
                    int firstPlace = PlayerPrefs.GetInt("Lv2Score1");
                    int secondPlace = PlayerPrefs.GetInt("Lv2Score2");
                    int thirdPlace = PlayerPrefs.GetInt("Lv2Score3");

                   
                    if (score > firstPlace)
                    {
                        HSPanel.SetActive(true);
                        
                    }
                    else if (score > secondPlace)
                    {
                        HSPanel.SetActive(true);
                    
                    }
                    else if (score > thirdPlace)
                    {
                        HSPanel.SetActive(true);
                     
                    }
                }

                //-------------------------------------------------------------------------
                if (scene.name == "Level3")
                {
                    PlayerPrefs.SetInt("unlockLevel", 4);
                    int firstPlace = PlayerPrefs.GetInt("Lv3Score1");
                    int secondPlace = PlayerPrefs.GetInt("Lv3Score2");
                    int thirdPlace = PlayerPrefs.GetInt("Lv3Score3");

                  
                    if (score > firstPlace)
                    {
                        HSPanel.SetActive(true);
                      
                    }
                    else if (score > secondPlace)
                    {
                        HSPanel.SetActive(true);
                     
                    }
                    else if (score > thirdPlace)
                    {
                        HSPanel.SetActive(true);
                      
                    }
                }

                //-----------------------------------------------------------------------------------------------
                if (scene.name == "Level4")
                {
                    PlayerPrefs.SetInt("unlockLevel", 5);
                    int firstPlace = PlayerPrefs.GetInt("Lv4Score1");
                    int secondPlace = PlayerPrefs.GetInt("Lv4Score2");
                    int thirdPlace = PlayerPrefs.GetInt("Lv4Score3");

                    if (score > firstPlace)
                    {
                        HSPanel.SetActive(true);
                        
                    }
                    else if (score > secondPlace)
                    {
                        HSPanel.SetActive(true);
                       
                    }
                    else if (score > thirdPlace)
                    {
                        HSPanel.SetActive(true);
                       
                    }
                }

                //------------------------------------------------------------------------------------------------------------
                if (scene.name == "Level5")
                {
                    PlayerPrefs.SetInt("unlockLevel", 6);
                    int firstPlace = PlayerPrefs.GetInt("Lv5Score1");
                    int secondPlace = PlayerPrefs.GetInt("Lv5Score2");
                    int thirdPlace = PlayerPrefs.GetInt("Lv5Score3");

                    
                    if (score > firstPlace)
                    {
                        HSPanel.SetActive(true);
                       
                    }
                    else if (score > secondPlace)
                    {
                        HSPanel.SetActive(true);
                        
                    }
                    else if (score > thirdPlace)
                    {
                        HSPanel.SetActive(true);
                       
                    }
                }

                //------------------------------------------------------------------------------------------------------------------------
                if (scene.name == "Level6")
                {
                    PlayerPrefs.SetInt("unlockLevel", 7);
                    int firstPlace = PlayerPrefs.GetInt("Lv6Score1");
                    int secondPlace = PlayerPrefs.GetInt("Lv6Score2");
                    int thirdPlace = PlayerPrefs.GetInt("Lv6Score3");

                   
                    if (score > firstPlace)
                    {
                        HSPanel.SetActive(true);
                       
                    }
                    else if (score > secondPlace)
                    {
                        HSPanel.SetActive(true);
                       
                    }
                    else if (score > thirdPlace)
                    {
                        HSPanel.SetActive(true);
                       
                    }
                }

                //---------------------------------------------------------------------------------------------------------------------------
                if (scene.name == "Level7")
                {
                    int firstPlace = PlayerPrefs.GetInt("Lv7Score1");
                    int secondPlace = PlayerPrefs.GetInt("Lv7Score2");
                    int thirdPlace = PlayerPrefs.GetInt("Lv7Score3");

                 
                    if (score > firstPlace)
                    {
                        Debug.Log(name);
                        HSPanel.SetActive(true);
                      
                    }
                    else if (score > secondPlace)
                    {
                        HSPanel.SetActive(true);
                       
                    }
                    else if (score > thirdPlace)
                    {
                        HSPanel.SetActive(true);
                       
                    }
                }


            }
        }
    }

        public void getInput(string nameIn)
        {
            name = nameIn;
            enterName.SetActive(false);
            setHighScore();
        }

        public void setHighScore()
        {
            if (scene.name == "Level1")
            {
                PlayerPrefs.SetInt("unlockLevel", 2);
                int firstPlace = PlayerPrefs.GetInt("Lv1Score1");
                int secondPlace = PlayerPrefs.GetInt("Lv1Score2");
                int thirdPlace = PlayerPrefs.GetInt("Lv1Score3");

                string secondName = PlayerPrefs.GetString("Lv1Name2");
                string thirdName = PlayerPrefs.GetString("Lv1Name3");
                if (score > firstPlace)
                {
                    HSPanel.SetActive(true);
                    //enterName.enabled = true;
                    secondPlace = PlayerPrefs.GetInt("Lv1Score1");
                    thirdPlace = PlayerPrefs.GetInt("Lv1Score2");
                    PlayerPrefs.SetInt("Lv1Score2", secondPlace);
                    PlayerPrefs.SetInt("Lv1Score3", thirdPlace);
                    PlayerPrefs.SetInt("Lv1Score1", score);
                    secondName = PlayerPrefs.GetString("Lv1Name1");
                    thirdName = PlayerPrefs.GetString("Lv1Name2");
                    PlayerPrefs.SetString("Lv1Name1", name);
                    PlayerPrefs.SetString("Lv1Name2", secondName);
                    PlayerPrefs.SetString("Lv1Name3", thirdName);


                }
                else if (score > secondPlace)
                {
                    HSPanel.SetActive(true);
                    thirdName = PlayerPrefs.GetString("Lv1Name2");
                    PlayerPrefs.SetString("Lv1Name3", thirdName);
                    PlayerPrefs.SetString("Lv1Name2", name);
                    thirdPlace = PlayerPrefs.GetInt("Lv1Score2");
                    PlayerPrefs.SetInt("Lv1Score3", thirdPlace);
                    PlayerPrefs.SetInt("Lv1Score2", score);
                }
                else if (score > thirdPlace)
                {
                    HSPanel.SetActive(true);
                    PlayerPrefs.SetInt("Lv1Score3", score);
                    PlayerPrefs.SetString("Lv1Name3", name);
                }
            }

            //--------------------------------------------------------------
            if (scene.name == "Level2")
            {
                PlayerPrefs.SetInt("unlockLevel", 3);
                int firstPlace = PlayerPrefs.GetInt("Lv2Score1");
                int secondPlace = PlayerPrefs.GetInt("Lv2Score2");
                int thirdPlace = PlayerPrefs.GetInt("Lv2Score3");

                string secondName = PlayerPrefs.GetString("Lv2Name2");
                string thirdName = PlayerPrefs.GetString("Lv2Name3");
                if (score > firstPlace)
                {
                    HSPanel.SetActive(true);
                    secondPlace = PlayerPrefs.GetInt("Lv2Score1");
                    thirdPlace = PlayerPrefs.GetInt("Lv2Score2");
                    PlayerPrefs.SetInt("Lv2Score2", secondPlace);
                    PlayerPrefs.SetInt("Lv2Score3", thirdPlace);
                    PlayerPrefs.SetInt("Lv2Score1", score);
                    secondName = PlayerPrefs.GetString("Lv2Name1");
                    thirdName = PlayerPrefs.GetString("Lv2Name2");
                    PlayerPrefs.SetString("Lv2Name1", name);
                    PlayerPrefs.SetString("Lv2Name2", secondName);
                    PlayerPrefs.SetString("Lv2Name3", thirdName);
                }
                else if (score > secondPlace)
                {
                    HSPanel.SetActive(true);
                    thirdName = PlayerPrefs.GetString("Lv2Name2");
                    PlayerPrefs.SetString("Lv2Name3", thirdName);
                    PlayerPrefs.SetString("Lv2Name2", name);
                    thirdPlace = PlayerPrefs.GetInt("Lv2Score2");
                    PlayerPrefs.SetInt("Lv2Score3", thirdPlace);
                    PlayerPrefs.SetInt("Lv2Score2", score);
                }
                else if (score > thirdPlace)
                {
                    HSPanel.SetActive(true);
                    PlayerPrefs.SetString("Lv2Name3", name);
                    PlayerPrefs.SetInt("Lv2Score3", score);
                }
            }

            //-------------------------------------------------------------------------
            if (scene.name == "Level3")
            {
                PlayerPrefs.SetInt("unlockLevel", 4);
                int firstPlace = PlayerPrefs.GetInt("Lv3Score1");
                int secondPlace = PlayerPrefs.GetInt("Lv3Score2");
                int thirdPlace = PlayerPrefs.GetInt("Lv3Score3");

                string secondName = PlayerPrefs.GetString("Lv3Name2");
                string thirdName = PlayerPrefs.GetString("Lv3Name3");
                secondName = PlayerPrefs.GetString("Lv3Name1");
                thirdName = PlayerPrefs.GetString("Lv3Name2");
                PlayerPrefs.SetString("Lv3Name1", name);
                PlayerPrefs.SetString("Lv3Name2", secondName);
                PlayerPrefs.SetString("Lv3Name3", thirdName);
                if (score > firstPlace)
                {
                    HSPanel.SetActive(true);
                    secondPlace = PlayerPrefs.GetInt("Lv3Score1");
                    thirdPlace = PlayerPrefs.GetInt("Lv3Score2");
                    PlayerPrefs.SetInt("Lv3Score2", secondPlace);
                    PlayerPrefs.SetInt("Lv3Score3", thirdPlace);
                    PlayerPrefs.SetInt("Lv3Score1", score);
                }
                else if (score > secondPlace)
                {
                    HSPanel.SetActive(true);
                    thirdName = PlayerPrefs.GetString("Lv3Name2");
                    PlayerPrefs.SetString("Lv3Name3", thirdName);
                    PlayerPrefs.SetString("Lv3Name2", name);
                    thirdPlace = PlayerPrefs.GetInt("Lv3Score2");
                    PlayerPrefs.SetInt("Lv3Score3", thirdPlace);
                    PlayerPrefs.SetInt("Lv3Score2", score);
                }
                else if (score > thirdPlace)
                {
                    HSPanel.SetActive(true);
                    PlayerPrefs.SetString("Lv3Name3", name);
                    PlayerPrefs.SetInt("Lv3Score3", score);
                }
            }

            //-----------------------------------------------------------------------------------------------
            if (scene.name == "Level4")
            {
                PlayerPrefs.SetInt("unlockLevel", 5);
                int firstPlace = PlayerPrefs.GetInt("Lv4Score1");
                int secondPlace = PlayerPrefs.GetInt("Lv4Score2");
                int thirdPlace = PlayerPrefs.GetInt("Lv4Score3");

                string secondName = PlayerPrefs.GetString("Lv4Name2");
                string thirdName = PlayerPrefs.GetString("Lv4Name3");
                if (score > firstPlace)
                {
                    HSPanel.SetActive(true);
                    secondPlace = PlayerPrefs.GetInt("Lv4Score1");
                    thirdPlace = PlayerPrefs.GetInt("Lv4Score2");
                    PlayerPrefs.SetInt("Lv4Score2", secondPlace);
                    PlayerPrefs.SetInt("Lv4Score3", thirdPlace);
                    PlayerPrefs.SetInt("Lv4Score1", score);
                    secondName = PlayerPrefs.GetString("Lv4Name1");
                    thirdName = PlayerPrefs.GetString("Lv4Name2");
                    PlayerPrefs.SetString("Lv4Name1", name);
                    PlayerPrefs.SetString("Lv4Name2", secondName);
                    PlayerPrefs.SetString("Lv4Name3", thirdName);
                }
                else if (score > secondPlace)
                {
                    HSPanel.SetActive(true);
                    thirdName = PlayerPrefs.GetString("Lv4Name2");
                    PlayerPrefs.SetString("Lv4Name3", thirdName);
                    PlayerPrefs.SetString("Lv4Name2", name);
                    thirdPlace = PlayerPrefs.GetInt("Lv4Score2");
                    PlayerPrefs.SetInt("Lv4Score3", thirdPlace);
                    PlayerPrefs.SetInt("Lv4Score2", score);
                }
                else if (score > thirdPlace)
                {
                    HSPanel.SetActive(true);
                    PlayerPrefs.SetString("Lv4Name3", name);
                    PlayerPrefs.SetInt("Lv4Score3", score);
                }
            }

            //------------------------------------------------------------------------------------------------------------
            if (scene.name == "Level5")
            {
                PlayerPrefs.SetInt("unlockLevel", 6);
                int firstPlace = PlayerPrefs.GetInt("Lv5Score1");
                int secondPlace = PlayerPrefs.GetInt("Lv5Score2");
                int thirdPlace = PlayerPrefs.GetInt("Lv5Score3");

                string secondName = PlayerPrefs.GetString("Lv5Name2");
                string thirdName = PlayerPrefs.GetString("Lv5Name3");
                if (score > firstPlace)
                {
                    HSPanel.SetActive(true);
                    secondPlace = PlayerPrefs.GetInt("Lv5Score1");
                    thirdPlace = PlayerPrefs.GetInt("Lv5Score2");
                    PlayerPrefs.SetInt("Lv5Score2", secondPlace);
                    PlayerPrefs.SetInt("Lv5Score3", thirdPlace);
                    PlayerPrefs.SetInt("Lv5Score1", score);
                    secondName = PlayerPrefs.GetString("Lv5Name1");
                    thirdName = PlayerPrefs.GetString("Lv5Name2");
                    PlayerPrefs.SetString("Lv5Name1", name);
                    PlayerPrefs.SetString("Lv5Name2", secondName);
                    PlayerPrefs.SetString("Lv5Name3", thirdName);
                }
                else if (score > secondPlace)
                {
                    HSPanel.SetActive(true);
                    thirdName = PlayerPrefs.GetString("Lv5Name2");
                    PlayerPrefs.SetString("Lv5Name3", thirdName);
                    PlayerPrefs.SetString("Lv5Name2", name);
                    thirdPlace = PlayerPrefs.GetInt("Lv5Score2");
                    PlayerPrefs.SetInt("Lv5Score3", thirdPlace);
                    PlayerPrefs.SetInt("Lv5Score2", score);
                }
                else if (score > thirdPlace)
                {
                    HSPanel.SetActive(true);
                    PlayerPrefs.SetString("Lv5Name3", name);
                    PlayerPrefs.SetInt("Lv5Score3", score);
                }
            }

            //------------------------------------------------------------------------------------------------------------------------
            if (scene.name == "Level6")
            {
                PlayerPrefs.SetInt("unlockLevel", 7);
                int firstPlace = PlayerPrefs.GetInt("Lv6Score1");
                int secondPlace = PlayerPrefs.GetInt("Lv6Score2");
                int thirdPlace = PlayerPrefs.GetInt("Lv6Score3");

                string secondName = PlayerPrefs.GetString("Lv6Name2");
                string thirdName = PlayerPrefs.GetString("Lv6Name3");
                if (score > firstPlace)
                {
                    HSPanel.SetActive(true);
                    secondPlace = PlayerPrefs.GetInt("Lv6Score1");
                    thirdPlace = PlayerPrefs.GetInt("Lv6Score2");
                    PlayerPrefs.SetInt("Lv6Score2", secondPlace);
                    PlayerPrefs.SetInt("Lv6Score3", thirdPlace);
                    PlayerPrefs.SetInt("Lv6Score1", score);
                    secondName = PlayerPrefs.GetString("Lv6Name1");
                    thirdName = PlayerPrefs.GetString("Lv6Name2");
                    PlayerPrefs.SetString("Lv6Name1", name);
                    PlayerPrefs.SetString("Lv6Name2", secondName);
                    PlayerPrefs.SetString("Lv6Name3", thirdName);
                }
                else if (score > secondPlace)
                {
                    HSPanel.SetActive(true);
                    thirdName = PlayerPrefs.GetString("Lv6Name2");
                    PlayerPrefs.SetString("Lv6Name3", thirdName);
                    PlayerPrefs.SetString("Lv6Name2", name);
                    thirdPlace = PlayerPrefs.GetInt("Lv6Score2");
                    PlayerPrefs.SetInt("Lv6Score3", thirdPlace);
                    PlayerPrefs.SetInt("Lv6Score2", score);
                }
                else if (score > thirdPlace)
                {
                    HSPanel.SetActive(true);
                    PlayerPrefs.SetString("Lv6Name3", name);
                    PlayerPrefs.SetInt("Lv6Score3", score);
                }
            }

            //---------------------------------------------------------------------------------------------------------------------------
            if (scene.name == "Level7")
            {
                int firstPlace = PlayerPrefs.GetInt("Lv7Score1");
                int secondPlace = PlayerPrefs.GetInt("Lv7Score2");
                int thirdPlace = PlayerPrefs.GetInt("Lv7Score3");

                string secondName = PlayerPrefs.GetString("Lv7Name2");
                string thirdName = PlayerPrefs.GetString("Lv7Name3");
                if (score > firstPlace)
                {
                    Debug.Log(name);
                    HSPanel.SetActive(true);
                    secondPlace = PlayerPrefs.GetInt("Lv7Score1");
                    thirdPlace = PlayerPrefs.GetInt("Lv7Score2");
                    PlayerPrefs.SetInt("Lv7Score2", secondPlace);
                    PlayerPrefs.SetInt("Lv7Score3", thirdPlace);
                    PlayerPrefs.SetInt("Lv7Score1", score);
                    secondName = PlayerPrefs.GetString("Lv7Name1");
                    thirdName = PlayerPrefs.GetString("Lv7Name2");
                    PlayerPrefs.SetString("Lv7Name1", name);
                    PlayerPrefs.SetString("Lv7Name2", secondName);
                    PlayerPrefs.SetString("Lv1Name3", thirdName);
                }
                else if (score > secondPlace)
                {
                    HSPanel.SetActive(true);
                    thirdName = PlayerPrefs.GetString("Lv7Name2");
                    PlayerPrefs.SetString("Lv7Name3", thirdName);
                    PlayerPrefs.SetString("Lv7Name2", name);
                    thirdPlace = PlayerPrefs.GetInt("Lv7Score2");
                    PlayerPrefs.SetInt("Lv7Score3", thirdPlace);
                    PlayerPrefs.SetInt("Lv7Score2", score);
                }
                else if (score > thirdPlace)
                {
                    HSPanel.SetActive(true);
                    PlayerPrefs.SetString("Lv7Name3", name);
                    PlayerPrefs.SetInt("Lv7Score3", score);
                }
            }
        }
    }


