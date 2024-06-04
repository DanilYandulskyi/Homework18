using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Enemy : MonoBehaviour
{
    private Mover _movement;
    private Vector3 _target;

    private void Awake()
    {
        _movement = GetComponent<Mover>(); 
    }

    private void Update()
    {
        _movement.MovePosition(_target);     
    }

    public void Initialize(Vector3 target)
    {
        _target = target;
    }
}
