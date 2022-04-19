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
    }
}