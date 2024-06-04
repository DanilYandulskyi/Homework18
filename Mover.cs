using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField , Range(0, 100)] private float _speed;
    [SerializeField] private bool _isMoving = true;

    public void MovePosition(Vector3 target)
    {
        if (_isMoving == true)
        {
            Vector2 direction = (target - transform.position).normalized;
            transform.Translate(direction * (_speed * Time.deltaTime));

            if (transform.position == target)
            {
                _isMoving = false;
            }
        }
    }
}