using UnityEngine;

public class Rope : MonoBehaviour
{
    private LineRenderer _lineRenderer;

    [SerializeField] private Transform _target1;
    [SerializeField] private Transform _target2;

    private GameObject _player;

    private void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _player = GameObject.FindWithTag("Player");


    }

    private void Update()
    {
            _lineRenderer.SetPosition(0, _target1.position);
            _lineRenderer.SetPosition(1, _player.transform.position);
            _lineRenderer.SetPosition(2, _target2.position);
    }
}
