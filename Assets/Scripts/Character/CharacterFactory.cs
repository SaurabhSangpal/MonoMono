namespace Character
{
    /// <summary>
    /// The type of character that we can obtain from CharacterFactory.
    /// </summary>
    public enum CharacterType
    {
        /// <summary> The controllable player character. </summary>
        Player,
        /// <summary> Generic enemy character. To be updated at a later date </summary>
        Enemy
    }

    /// <summary>
    /// The character factory. Use to create/obtain player or enemy character references.
    /// </summary>
    public class CharacterFactory
    {
        /// <summary>
        /// Creates a new instance of the CharacterType and returns the interface to it.
        /// </summary>
        public ICharacter Create(CharacterType characterType)
        {
            switch (characterType)
            {
                case CharacterType.Player:
                    break;
                case CharacterType.Enemy:
                    break;
            }

            throw new System.NotImplementedException();
        }
    }
}
