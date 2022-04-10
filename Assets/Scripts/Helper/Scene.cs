using UnityEngine.SceneManagement;

public enum SceneId
{
    MainMenu = 0,
    Game = 1
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
                    return SceneId.Game;
                default:
                    throw new System.ArgumentOutOfRangeException();
            }
        }

        public static void LoadSceneAsync(SceneId scene)
        {
            SceneManager.LoadSceneAsync((int)scene);
        }
    }
}
