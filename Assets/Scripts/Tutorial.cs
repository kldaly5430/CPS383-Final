using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour {

    public int textState;
    public GameObject highlightEnemy;
    public GameObject highlightPanel;
    public GameObject highlightTroop;
    public GameObject highlightFunds;
    public GameObject highlightStart;
    public GameObject TextPanel;
    
    public Text tutorial;
    public Text continueTxt;
    // Use this for initialization
    void Start()
    {
        textState = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            textState += 1;
        }
        switch(textState){
            case 1:
                tutorial.text = "Welcome to the conflict, general. Your task is to defeat the enemy troops in every battlefield presented to you by hand picking an army of your own. Enemy troops will be located on the right handside of the field.";
                highlightEnemy.SetActive(true);
                break;
            case 2:
                tutorial.text = "At the top of your screen is a tool we refer to as the soldier selection panel. This tool is available to generals so that they may select desired troops and begin the battle at their pleasure. ";
                highlightEnemy.SetActive(false);
                highlightPanel.SetActive(true);
                break;
            case 3:
                tutorial.text = "We in the council have given you funds appropriate for each battle. Remaining funds are available visually at the highlighted area in the top left corner of the soldier selection panel.";
                highlightPanel.SetActive(false);
                highlightFunds.SetActive(true);
                break;
            case 4:
                tutorial.text = "On the right side of the soldier selection panel are all of the different types of soldiers in the empire. Beneath each soldier's image is the funds required in order to add that soldier type to your army. If you do not have enough funds the soldiers will refuse to participate.";
                highlightFunds.SetActive(false);
                highlightTroop.SetActive(true);
                break;
            case 5:
                tutorial.text = "Once your army has been selected and you can begin the battle by signalling the war horns. To do so press the 'START' button beneath the funds on your soldier selection panel.";
                highlightTroop.SetActive(false);
                highlightStart.SetActive(true);
                break;
            case 6:
                tutorial.text = "Once a battlefield has been conquered you may revisit it through the main menu. Be aware you may only visit the next battlefield if you have successfully conquered the current one.";
                highlightStart.SetActive(false);
                break;
            case 7:
                tutorial.text = "It's time for you to lead your first battle, good luck.";
                break;
            case 8:
                tutorial.text = "";
                continueTxt.text = "";
                TextPanel.SetActive(false);
                break;
        }
	}
}
