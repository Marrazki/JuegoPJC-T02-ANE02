using UnityEngine;
using UnityEngine.InputSystem;

public class Menu : MonoBehaviour
{
    public bool menuOpened = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenMenu()
    {
        if (menuOpened)
        { 
        Debug.Log("Cerrar Menu" );
        }
        else if (!menuOpened)
        {
            Debug.Log("Abrir Menu");
        }


        menuOpened = !menuOpened;
    }
    public void CloseGame()
    {
        Application.Quit();
    }
}
