using Newtonsoft.Json;

namespace Input
{
    [System.Serializable]
    public class KeyBinds
    {
        // If the input device is a joystick, we won't allow to rebind the input.
        public bool isJoystick;

        // These values will be null/empty when input device is a joystick.
        public string left;
        public string right;
        public string up;
        public string down;
        public string altLeft;
        public string altRight;
        public string altUp;
        public string altDown;

        public string jump;
        public string dash;
        public string crouch;
        public string attack;

        internal static KeyBinds LoadFromDisk()
        {
            if (!Helper.PersistentPathIO.Exists("keybinds.json"))
            {
                var kb = new KeyBinds();
                return kb;
            }
            var keyBinds = JsonConvert.DeserializeObject<KeyBinds>(Helper.PersistentPathIO.LoadFile("keybinds.json"));
            if (keyBinds != null)
                return keyBinds;
            throw new System.Exception("Failed to load or parse key binds");
        }
    }
}