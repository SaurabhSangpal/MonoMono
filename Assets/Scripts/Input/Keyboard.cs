namespace Input
{
    internal class Keyboard : IController
    {
        private KeyBinds kb;

        public void Initialize(KeyBinds keyBinds)
        {
            UnityEngine.Debug.Assert(keyBinds != null);
            kb = keyBinds;
        }

        public float GetHorizontalAxis()
        {
            throw new System.NotImplementedException();
        }

        public float GetVerticalAxis()
        {
            throw new System.NotImplementedException();
        }

        public bool IsJumpPressed()
        {
            throw new System.NotImplementedException();
        }

        public bool IsDashPressed()
        {
            throw new System.NotImplementedException();
        }

        public bool IsCrouchPressed()
        {
            throw new System.NotImplementedException();
        }

        public bool IsAttackPressed()
        {
            throw new System.NotImplementedException();
        }
    }
}