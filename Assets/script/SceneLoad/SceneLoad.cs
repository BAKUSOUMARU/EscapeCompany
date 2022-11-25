using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    [SerializeField]
    [Header("���[�h����V�[���̖��O")]
    string _scene = default;

    public void LoadScene()
    {
        SceneManager.LoadScene(_scene);
    }
}
