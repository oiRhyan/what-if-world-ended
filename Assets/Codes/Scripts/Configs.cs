using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject optionsPanel;

    public void ShowOptions()
    {
        optionsPanel.SetActive(true);
    }
    public void BackToMenu()
    {
        optionsPanel.SetActive(false);
    }
}
