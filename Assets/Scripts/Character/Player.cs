using UnityEngine;

namespace Character
{
    public class Player
    {
        private Transform transform;

        public Player(GameObject go)
        {
            transform = go.transform;
        }

        public void Jump() { }

        public void Dash() { }

        public void Crouch() { }

        public void Attack() { }
    }
}