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
    }
}