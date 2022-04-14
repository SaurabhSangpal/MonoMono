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
                kb.isJoystick = false;
                kb.up = "up";
                kb.down = "down";
                kb.left = "left";
                kb.right = "right";
                kb.altUp = "w";
                kb.altDown = "s";
                kb.altLeft = "a";
                kb.altRight = "d";
                kb.jump = "space";
                kb.dash = "z";
                kb.crouch = "c";
                kb.attack = "f";
                Helper.PersistentPathIO.SaveFile("keybinds.json", JsonConvert.SerializeObject(kb, Formatting.Indented));

                return kb;
            }
            var keyBinds = JsonConvert.DeserializeObject<KeyBinds>(Helper.PersistentPathIO.LoadFile("keybinds.json"));
            if (keyBinds != null)
                return keyBinds;
            throw new System.Exception("Failed to load or parse key binds");
        }
    }
}