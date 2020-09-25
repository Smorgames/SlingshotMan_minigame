using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private Vector3 _offset;
    private Transform _objectToFollow;

    private bool _isFollowing = false;
    private float _timer = 0f;

    private void Update()
    {
        if (_isFollowing)
            StartFollowTarget();
    }

    public void IsFollowing(bool isFollowing, Transform _transform)
    {
        _isFollowing = isFollowing;

        if (_isFollowing)
            _objectToFollow = _transform;
    }

    private void StartFollowTarget()
    {
        transform.position = Vector3.Lerp(transform.position, 
        new Vector3(transform.position.x, _objectToFollow.position.y, _objectToFollow.position.z) - _offset, _timer);
        _timer += Time.deltaTime * 0.5f;

        if (_timer >= 1f)
        {
            _isFollowing = false;
            _timer = 0f;
        }
    }
}