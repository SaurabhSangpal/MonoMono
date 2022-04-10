namespace Input
{
    internal interface IController
    {
        float GetHorizontalAxis();
        float GetVerticalAxis();

        bool IsJumpPressed();
        bool IsDashPressed();
        bool IsCrouchPressed();
        bool IsAttackPressed();
    }
}