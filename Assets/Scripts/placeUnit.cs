using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class placeUnit : MonoBehaviour {

    public GameObject knight;
    public GameObject archer;
    public GameObject wizard;
    public GameObject barbarian;
    public GameObject axeMan;
    public GameObject samurai;
    public GameObject orc;

    public bool fight = false;
    //public AudioSource horn;
    //public AudioClip clip;

    public Button btnKnight;
    public Button btnArcher;
    public Button btnWizard;
    public Button btnBarbairan;
    public Button btnAxeman;
    public Button btnSamurai;
    public Button btnOrc;
    public Button btnFight;

    private int unitSpawn = 0;
    public bool spawnable = true;
    private Vector3 mousePos;

    public int min;
    public int sec;

    public Text balanceTxt;
    public int balance;
    public int cost;
	private Scene scene;

	// Use this for initialization
	void Start () {
        Button btnknight = btnKnight.GetComponent<Button>();
        Button btnarcher = btnArcher.GetComponent<Button>();
        Button btnwizard = btnWizard.GetComponent<Button>();
        Button btnbarbarian = btnBarbairan.GetComponent<Button>();
        Button btnaxeman = btnAxeman.GetComponent<Button>();
        Button btnsamurai = btnSamurai.GetComponent<Button>();
        Button btnorc = btnOrc.GetComponent<Button>();
        Button FIGHT = btnFight.GetComponent<Button>();

        btnknight.onClick.AddListener(spawnKnight);
        btnarcher.onClick.AddListener(spawnArcher);
        btnwizard.onClick.AddListener(spawnWizard);
        btnbarbarian.onClick.AddListener(spawnBarbarian);
        btnaxeman.onClick.AddListener(spawnAxeman);
        btnsamurai.onClick.AddListener(spawnSamurai);
        btnorc.onClick.AddListener(spawnOrc);
        FIGHT.onClick.AddListener(Fight);

        Time.timeScale = 1;

        scene = SceneManager.GetActiveScene ();
		if( scene.name == "Level1") {
			balance = 700;
		}
		if (scene.name == "Level2")
		{
			balance = 800;
		}
		if (scene.name == "Level3")
		{
			balance = 1000;
		}
		if (scene.name == "Level4")
		{
			balance = 1250;
		}
        if(scene.name == "Level5")
        {
            balance = 1450;
        }
		if (scene.name == "Level6")
		{
			balance = 1600;
		}
		if (scene.name == "Level7")
		{
			balance = 2000;
		}
        
    }

    // Update is called once per frame
    void Update () {
        balanceTxt.text = "Money: " + balance;
		if(Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            mousePos.z = 0;
            Vector3 objPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 5));
            if (cost > balance)
                spawnable = false;
            if (fight == false)
            {
                if (spawnable == true)
                {
                    switch (unitSpawn)
                    {
                        case 1:
                            Instantiate(knight, objPos, Quaternion.identity);
                            balance -= 250;
                            break;
                        case 2:
                            Instantiate(archer, objPos, Quaternion.identity);
                            balance -= 200;
                            break;
                        case 3:
                            Instantiate(wizard, objPos, Quaternion.identity);
                            balance -= 500;
                            break;
                        case 4:
                            Instantiate(barbarian, objPos, Quaternion.identity);
                            balance -= 350;
                            break;
                        case 5:
                            Instantiate(axeMan, objPos, Quaternion.identity);
                            balance -= 100;
                            break;
                        case 6:
                            Instantiate(samurai, objPos, Quaternion.identity);
                            balance -= 600;
                            break;
                        case 7:
                            Instantiate(orc, objPos, Quaternion.identity);
                            balance -= 800;
                            break;
                        default:
                            break;
                    }
                }
            }
            
        }

	}

    public void Fight()
    {
        fight = true;
        FindObjectOfType<AudioManager>().Play("yelling");
        FindObjectOfType<AudioManager>().Play("Horn");
        StartCoroutine(OneSecTimer());
    }

    IEnumerator OneSecTimer()
    {
        while (fight == true)
        {
            yield return new WaitForSeconds(1);
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
            }
        }
    }

    public void OnMouseEnter()
    {
        spawnable = false;
    }

    public void OnMouseOver()
    {
        spawnable = false;
    }

    public void OnMouseExit()
    {
        spawnable = true;
    }

    void spawnKnight()
    {
        unitSpawn = 1;
        cost = 250;
    }
    
    void spawnArcher()
    {
        unitSpawn = 2;
        cost = 200;
    }

    void spawnWizard()
    {
        unitSpawn = 3;
        cost = 500;
    }

    void spawnBarbarian()
    {
        unitSpawn = 4;
        cost = 350;
    }

    void spawnAxeman()
    {
        unitSpawn = 5;
        cost = 100;
    }

    void spawnSamurai()
    {
        unitSpawn = 6;
        cost = 600;
    }

    void spawnOrc()
    {
        unitSpawn = 7;
        cost = 800;
    }
}
