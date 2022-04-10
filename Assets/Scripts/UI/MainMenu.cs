using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    internal class MainMenu
    {
        private Button @continue, newGame, settings, quit;

        internal Button Continue => @continue;
        internal Button NewGame => newGame;
        internal Button Settings => settings;
        internal Button Quit => quit;

        internal void Initialize()
        {
            var root = GameObject.Find("Menu");
            if (root is null)
                throw new System.NullReferenceException("Root not found!");
            var btnParent = root.transform.Find("BG/GameObject");
            if (btnParent is null)
                throw new System.NullReferenceException("Parent not found!");

            @continue = btnParent.transform.Find("Continue").GetComponent<Button>();
            newGame = btnParent.transform.Find("New Game").GetComponent<Button>();
            settings = btnParent.transform.Find("Settings").GetComponent<Button>();
            quit = btnParent.transform.Find("Quit").GetComponent<Button>();

            @continue.onClick.RemoveAllListeners();
            newGame.onClick.RemoveAllListeners();
            settings.onClick.RemoveAllListeners();
            quit.onClick.RemoveAllListeners();

            @continue.onClick.AddListener(OnContinue);
            newGame.onClick.AddListener(OnNewGame);
            settings.onClick.AddListener(OnSettings);
            quit.onClick.AddListener(OnQuit);
        }

        private void OnContinue()
        {
        }

        private void OnNewGame()
        {
        }

        private void OnSettings()
        {
        }

        private void OnQuit()
        {
        }
    }
}
