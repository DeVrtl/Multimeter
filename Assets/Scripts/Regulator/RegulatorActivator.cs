using UnityEngine;

public class RegulatorActivator : MonoBehaviour
{
    [SerializeField] private Material _glow;
    [SerializeField] private Material _original;
    [SerializeField] private Renderer _renderer;
    [SerializeField] private RegulatorRotation _rotation;

    private void OnMouseEnter()
    {
        _rotation.enabled = true;
        _renderer.material = _glow;
    }

    private void OnMouseExit()
    {
        _rotation.enabled = false;
        _renderer.material = _original;
    }
}
