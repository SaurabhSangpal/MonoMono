using UnityEngine.SceneManagement;

public enum SceneId
{
    MainMenu,
    InGame
}

namespace Helper
{
    public class Scene
    {
        public static SceneId GetActiveScene()
        {
            var scene = SceneManager.GetActiveScene();
            switch (scene.buildIndex)
            {
                case 0:
                    return SceneId.MainMenu;
                case 1:
                    return SceneId.InGame;
                default:
                    throw new System.ArgumentOutOfRangeException();
            }
        }
    }
}
