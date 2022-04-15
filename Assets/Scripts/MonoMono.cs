using UnityEngine;

/// <summary>
/// The only MonoBehaviour file.
/// </summary>
public class MonoMono : MonoBehaviour
{
    private UI.MainMenu mainMenu;

    private Input.KeyBinds keyBinds;
    private Input.IController controller;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        keyBinds = Input.KeyBinds.LoadFromDisk();
        controller = new Input.Keyboard();
        controller.Initialize(keyBinds);
    }

    private void Start()
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

    private void Update()
    {
    }
}
