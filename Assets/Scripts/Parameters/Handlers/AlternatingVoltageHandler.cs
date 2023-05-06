using UnityEngine;
using TMPro;

[RequireComponent(typeof(AlternatingVoltage))]
public class AlternatingVoltageHandler : MonoBehaviour
{
    [SerializeField] private BaseValues _baseValues;
    [SerializeField] private TMP_Text _multimeterDisplay;
    [SerializeField] private TMP_Text _canvas;

    private AlternatingVoltage _alternatingVoltage;

    private void Awake()
    {
        _alternatingVoltage = GetComponent<AlternatingVoltage>();
    }

    private void OnEnable()
    {
        _alternatingVoltage.Passed += OnPassed;
    }

    private void OnDisable()
    {
        _alternatingVoltage.Passed -= OnPassed;
    }

    private void OnPassed()
    {
        _multimeterDisplay.text = _baseValues.AlternatingVoltage.ToString();
        _canvas.text = _baseValues.AlternatingVoltage.ToString();
    }
}
