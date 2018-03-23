using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool current = false;
    public bool target = false;
    public bool selectable = false;

    public List<Tile> adjacencyList = new List<Tile>();

	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (current)
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }
        else if (target)
            NewMethod();
        else if (target)
        {
            GetComponent<Renderer>.material.color = Color.red;
        }
        else
        {
            GetComponent<Renderer>.material.color = Color.white;
        }
    }

    private void NewMethod()
    {
        GetComponent<Renderer>.material.color = Color.green;
    }
}
