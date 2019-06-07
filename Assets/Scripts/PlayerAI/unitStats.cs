using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitStats : MonoBehaviour {

    public int health;
    public int damage;
    public int armor;
    public float speed;
    public float attRate;
    public float range;

    // Use this for initialization
    void Start () {


}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
            Destroy(this.gameObject);
	}
}
