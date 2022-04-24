using UnityEngine;

namespace Character
{
    /// <summary>
    /// The character interface. All characters are derived from this.
    /// </summary>
    public interface ICharacter
    {
        /// <summary>
        /// The GameObject that this character represents.
        /// </summary>
        GameObject GameObject { get; }

        /// <summary>
        /// The health of this character.
        /// </summary>
        int Health { get; }

        /// <summary>
        /// The speed at which the character can move.
        /// </summary>
        float MoveSpeed { get; }

        /// <summary>
        /// The distance covered by the dash.
        /// </summary>
        float DashDistance { get; }

        /// <summary>
        /// The amount of damage this character can deal in one hit.
        /// </summary>
        int AttackDamage { get; }

        /// <summary>
        /// Move in the given direction.
        /// </summary>
        void Move(Vector2 direction);

        /// <summary>
        /// Jump in the air.
        /// </summary>
        void Jump();

        /// <summary>
        /// Dash in the direction that the character is facing.
        /// </summary>
        void Dash();

        /// <summary>
        /// Toggle the crouch state of the character.
        /// </summary>
        void Crouch();

        /// <summary>
        /// Perform an attack.
        /// </summary>
        void Attack();

        /// <summary>
        /// Receive damage equal to <see cref="damage"/>.
        /// </summary>
        void TakeDamage(int damage);

        /// <summary>
        /// Kill the character.
        /// </summary>
        void Die();
    }
}
