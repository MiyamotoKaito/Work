using UnityEngine;

public class KeyController : ItemData
{
    public override void Active()
    {
        Debug.Log("�����Q�b�g");
        _spriteRenderer.color = Color.white;
    }
}
