using UnityEngine;
using TMPro;

public abstract class Handler : MonoBehaviour
{
    [SerializeField] private TMP_Text _multimeterDisplay;
    [SerializeField] private TMP_Text _canvas;

    protected void RewriteText(float multimeterValue)
    {
        _multimeterDisplay.text = multimeterValue.ToString();
        _canvas.text = multimeterValue.ToString();
    }
}
