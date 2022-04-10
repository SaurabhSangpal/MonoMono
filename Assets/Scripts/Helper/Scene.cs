using UnityEngine.SceneManagement;

public enum SceneId
{
    MainMenu = 0,
    Game = 1,
    Total  // Total elements in this enum, not to be used elsewhere.
}

namespace Helper
{
    public class Scene
    {
        public static SceneId GetActiveScene()
        {
            var scene = SceneManager.GetActiveScene();
            if (scene.buildIndex >= (int)SceneId.Total)
                throw new System.ArgumentOutOfRangeException("Element missing in enum");

            return (SceneId)scene.buildIndex;
        }

        public static void LoadSceneAsync(SceneId scene)
        {
            SceneManager.LoadSceneAsync((int)scene);
        }
    }
}
