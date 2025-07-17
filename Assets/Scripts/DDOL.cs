using UnityEngine;
using UnityEngine.UI;

public class DDOL : MonoBehaviour
{
    [SerializeField] GameObject _player;
    private bool _isStarted;
    void Start()
    {
        if (FindObjectsOfType<DDOL>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            _isStarted = true;
        }
    }
    /// <summary>
    /// ÉvÉåÉCÉÑÅ[Çï€ë∂
    /// </summary>
    /// <param name="player"></param>
    public void SetPlayer(InputField player)
    {
        _player = player.gameObject;
    }
    private void OnLevelWasLoaded(int level)
    {
        if (_isStarted) ShowPlayer();
    }
    private void ShowPlayer()
    {
        Instantiate(_player);
    }
}
