using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    [SerializeField]
    [Header("ロードするシーンの名前")]
    string _scene = default;

    public void LoadScene()
    {
        SceneManager.LoadScene(_scene);
    }
}
