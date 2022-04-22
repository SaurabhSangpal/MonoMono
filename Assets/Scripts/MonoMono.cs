using UnityEngine;

/// <summary>
/// The only MonoBehaviour file.
/// </summary>
public class MonoMono : MonoBehaviour
{
    private UI.MainMenu mainMenu;

    private Input.KeyBinds keyBinds;
    private Input.IController controller;

    private Character.Player player;

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
        var activeScene = Helper.Scene.GetActiveScene();
        if (activeScene == SceneId.MainMenu)
        {
            mainMenu = new UI.MainMenu();
            mainMenu.Initialize();
        }
        else if (activeScene == SceneId.Game)
        {
            player = new Character.Player(GameObject.Find("Player"));
        }
    }

    private void Update()
    {
    }
}
