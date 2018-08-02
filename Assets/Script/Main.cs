using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
    public GameObject MainMenu;
    public GameObject helpPage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (MainMenu.activeSelf == true)
                Application.Quit();
            else
                MainMenu.SetActive(true);
        }
	
	}

    public void Play()
    {
        MainMenu.SetActive(false);
        helpPage.SetActive(false);
    }

    public void Help()
    {
        MainMenu.SetActive(false);
        helpPage.SetActive(true);
    }
}
