using UnityEngine;

/// <summary>
/// The only MonoBehaviour file.
/// </summary>
public class MonoMono : MonoBehaviour
{
    private UI.MainMenu mainMenu;

    private Input.KeyBinds keyBinds;
    private Input.IController controller;

    private Character.ICharacter player;

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
            player = Character.CharacterFactory.Create(Character.CharacterType.Player);
        }
    }

    private void Update()
    {
        if (player == null)
            return;

        // TODO - We may need an input queue here.
        var hor = controller.GetHorizontalAxis();
        var ver = controller.GetVerticalAxis();
        player.Move(new Vector2(hor, ver));

        // Only allowing one action for now - crouch, dash, or jump in one frame.
        if (controller.IsCrouchPressed())
            player.Crouch();
        else if (controller.IsDashPressed())
            player.Dash();
        else if (controller.IsJumpPressed())
            player.Jump();

        if (controller.IsAttackPressed())
            player.Attack();
    }
}
