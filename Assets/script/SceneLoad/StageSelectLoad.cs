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
                GameManager.instance.StageCountSet(20);
                GameManager.instance.FreeLevelOff();
                GameManager.instance.FreeStageCountSet(0);
                LoadScene();
                break;

            case StageLevel.hard:
                GameManager.instance.StageCountSet(40);
                GameManager.instance.FreeLevelOff();
                GameManager.instance.FreeStageCountSet(0);
                LoadScene();
                break;

            case StageLevel.freelevel:
                if (int.Parse(_inpotText.text) > 0 || _inpotText.text == null)
                {
                    LoadScene();
                    GameManager.instance.FreeStageCountSet(int.Parse(_inpotText.text));
                    GameManager.instance.FreeLevelOn();
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
