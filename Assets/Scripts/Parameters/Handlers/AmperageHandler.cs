using UnityEngine;
using TMPro;

[RequireComponent(typeof(Amperage))]
public class AmperageHandler : MonoBehaviour
{
    [SerializeField] private BaseValues _baseValues;
    [SerializeField] private TMP_Text _multimeterDisplay;
    [SerializeField] private TMP_Text _canvas;

    private Amperage _amperage;

    private void Awake()
    {
        _amperage = GetComponent<Amperage>();
    }

    private void OnEnable()
    {
        _amperage.Passed += OnPassed;
    }

    private void OnDisable()
    {
        _amperage.Passed -= OnPassed;
    }

    private void OnPassed()
    {
        _multimeterDisplay.text = _baseValues.Amperage.ToString();
        _canvas.text = _baseValues.Amperage.ToString();
    }
}
