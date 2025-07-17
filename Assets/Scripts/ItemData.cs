using UnityEngine;

public abstract class ItemData : MonoBehaviour
{
    [SerializeField] Activetime _whenActivated;
    [SerializeField] Color _color;
    public SpriteRenderer _spriteRenderer;
    public abstract void Active();
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_whenActivated == Activetime.Get)
        {
            Active();
            Destroy(gameObject);
        }
    }
    enum Activetime
    {
        Get,
    }
}
