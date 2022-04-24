using UnityEngine;

namespace Character
{
    public class Player : BaseCharacter
    {
        public Player(GameObject go) : base(go) { }

        public override void Jump() { }
        public override void Dash() { }
        public override void Crouch() { }
        public override void Attack() { }
    }
}
