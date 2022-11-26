using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelectLoad : SceneLoad
{
    [SerializeField]
    [Header("遷移される先の難易度の設定")]
    StageLevel _stagelevel;

    [SerializeField] GameObject _popup;

    [SerializeField]
    [Header("フリーレベルの入力されるText")]
    Text _inpotText;
    public void SelectStage()
    {
        GameManager.instance.GameReset();
        switch (_stagelevel)
        {
            case StageLevel.Normal:
                GameManager.instance.stagecount = 20;
                GameManager.instance.isfreelevel = false;
                GameManager.instance.freelevel = 0;
                LoadScene();
                break;

            case StageLevel.hard:
                GameManager.instance.stagecount = 40;
                GameManager.instance.isfreelevel = false;
                GameManager.instance.freelevel = 0;
                LoadScene();
                break;

            case StageLevel.freelevel:
                if (int.Parse(_inpotText.text) > 0 || _inpotText.text == null)
                {
                    LoadScene();
                    GameManager.instance.freelevel = int.Parse(_inpotText.text);
                    GameManager.instance.isfreelevel = true;
                }
                else
                {
                    _popup.SetActive(true);
                }
                break;
        }
    }

    enum StageLevel
    {
        Normal,
        hard,
        freelevel
    }
}
