using UnityEngine;
using TMPro;

[RequireComponent(typeof(Resistance))]
public class ResistanceHandler : MonoBehaviour
{
    [SerializeField] private BaseValues _baseValues;
    [SerializeField] private TMP_Text _multimeterDisplay;
    [SerializeField] private TMP_Text _canvas;

    private Resistance _resistance;

    private void Awake()
    {
        _resistance = GetComponent<Resistance>();
    }

    private void OnEnable()
    {
        _resistance.Passed += OnPassed;
    }
    private void OnDisable()
    {
        _resistance.Passed -= OnPassed;
    }

    private void OnPassed()
    {
        _multimeterDisplay.text = _baseValues.Resistance.ToString();
        _canvas.text = _baseValues.Resistance.ToString();
    }
}
