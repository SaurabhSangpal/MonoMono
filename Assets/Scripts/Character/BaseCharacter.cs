using UnityEngine;

namespace Character
{
    public abstract class BaseCharacter : ICharacter
    {
        public GameObject GameObject { get; protected set; }
        public int Health { get; protected set; }
        public float MoveSpeed { get; protected set; }
        public float DashDistance { get; protected set; }
        public int AttackDamage { get; protected set; }

        public BaseCharacter(GameObject go)
        {
            GameObject = go;
        }

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

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
                Die();
        }

        public void Die()
        {
            throw new System.NotImplementedException();
        }
    }
}
