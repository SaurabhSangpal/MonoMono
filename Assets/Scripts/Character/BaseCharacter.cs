using UnityEngine;

namespace Character
{
    public abstract class BaseCharacter : ICharacter
    {
        public GameObject GameObject { get; private set; }
        public float MoveSpeed { get; private set; }
        public float DashDistance { get; private set; }

        // TODO: Can probably improve.
        public void Move(Vector2 direction)
        {
            direction = MoveSpeed * Time.deltaTime * direction;
            GameObject.transform.position += new Vector3(direction.x, 0, direction.y);
        }

        public abstract void Jump();
        public abstract void Dash();
        public abstract void Crouch();
        public abstract void Attack();
    }
}
