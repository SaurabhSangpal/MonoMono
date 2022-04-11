namespace Input
{
    /// <summary>
    /// Represents a controller - can be a keyboard, gamepad, or touch screen.
    /// </summary>
    internal interface IController
    {
        /// <summary> Returns value between -1 to 1, -1 being left and 1 being right. </summary>
        float GetHorizontalAxis();
        /// <summary> Returns value between -1 to 1, -1 being down and 1 being up. </summary>
        float GetVerticalAxis();

        /// <summary> Returns true if the player has pressed the jump button in this frame. </summary>
        bool IsJumpPressed();
        /// <summary> Returns true if the player has pressed the dash button in this frame. </summary>
        bool IsDashPressed();
        /// <summary> Returns true if the player has pressed the crouch button in this frame.
        /// </summary>
        bool IsCrouchPressed();
        /// <summary> Returns true if the player has pressed the attack button in this frame.
        /// </summary>
        bool IsAttackPressed();
    }
}