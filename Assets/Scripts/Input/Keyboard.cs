using UInput = UnityEngine.Input;

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
            if (UInput.GetKey(kb.left) && UInput.GetKey(kb.right))
            {
                return 0;
            }
            else if (UInput.GetKey(kb.left))
            {
                return -1;
            }
            else if (UInput.GetKey(kb.right))
            {
                return 1;
            }
            return 0;
        }

        public float GetVerticalAxis()
        {
            if (UInput.GetKey(kb.down) && UInput.GetKey(kb.up))
            {
                return 0;
            }
            else if (UInput.GetKey(kb.down))
            {
                return -1;
            }
            else if (UInput.GetKey(kb.up))
            {
                return 1;
            }
            return 0;
        }

        public bool IsJumpPressed()
        {
            return UInput.GetKey(kb.jump);
        }

        public bool IsDashPressed()
        {
            return UInput.GetKey(kb.dash);
        }

        public bool IsCrouchPressed()
        {
            return UInput.GetKey(kb.crouch);
        }

        public bool IsAttackPressed()
        {
            return UInput.GetKey(kb.attack);
        }
    }
}