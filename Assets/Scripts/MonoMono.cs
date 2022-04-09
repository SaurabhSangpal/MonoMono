using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The only MonoBehaviour file.
/// </summary>
public class MonoMono : MonoBehaviour
{
    private UI.MainMenu mainMenu;

    private void Awake()
    {
	DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
    }

    private void OnEnable()
    {
        if (Helper.Scene.GetActiveScene() == SceneId.MainMenu)
        {
            mainMenu = new UI.MainMenu();
            mainMenu.Initialize();
        }
    }

    void Update()
    {
    }
}
