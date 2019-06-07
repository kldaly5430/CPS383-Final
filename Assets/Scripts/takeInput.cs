using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class takeInput : MonoBehaviour {

    public string name;
    public Text outName;
    public GameObject enterName;

    public void getInput(string nameIn)
    {
        name = nameIn;
        outName.text = name;
        enterName.SetActive(false);
    }
}
