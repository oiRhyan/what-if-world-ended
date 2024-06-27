using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioJogo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IniciarOJogo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Nivel 2");
    }
}
