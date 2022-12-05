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
        GameManager.Instance.GameReset();
        switch (_stagelevel)
        {
            case StageLevel.Normal:
                StageManager.Instance.StageCountSet(20);
                StageManager.Instance.FreeLevelOff();
                StageManager.Instance.FreeStageCountSet(0);
                LoadScene();
                break;

            case StageLevel.hard:
                StageManager.Instance.StageCountSet(40);
                StageManager.Instance.FreeLevelOff();
                StageManager.Instance.FreeStageCountSet(0);
                LoadScene();
                break;

            case StageLevel.freelevel:
                if (int.Parse(_inpotText.text) > 0 || _inpotText.text == null)
                {
                    LoadScene();
                    StageManager.Instance.FreeStageCountSet(int.Parse(_inpotText.text));
                    StageManager.Instance.FreeLevelOn();
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
