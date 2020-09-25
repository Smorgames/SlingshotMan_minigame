using UnityEngine;

public class CatchPlayer : MonoBehaviour
{
    public float yOffset;

    private Rigidbody2D _rigidBody;
    private CircleCollider2D _collider;

    private GameObject _player;
    private float _timer = 0f;
    private bool _canTranslatePlayerToStartPoint = false;

    private GameObject _ropeTarget1, _ropeTarget2, _rope;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<CircleCollider2D>();

        _ropeTarget1 = GameObject.FindWithTag("RopeTarget1");
        _ropeTarget2 = GameObject.FindWithTag("RopeTarget2");
        _rope = GameObject.FindWithTag("Rope");
    }

    private void Update()
    {
        if (_canTranslatePlayerToStartPoint == true)
            TranslatePlayerToStartPoint();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            _player = collision.gameObject;

            Player playerComponent = _player.GetComponent<Player>();
            SpringJoint2D playersSpringJoint = _player.GetComponent<SpringJoint2D>();

            playersSpringJoint.enabled = true;

            playerComponent.SlingshotRigidBody = _rigidBody;

            playersSpringJoint.connectedBody = _rigidBody;

            playerComponent.SetBooleans(false, false);

            Spawner.instance.SpawnLevel(transform.position.y + 2f);

            _collider.enabled = false;

            _canTranslatePlayerToStartPoint = true;

            Camera.main.GetComponent<FollowTarget>().IsFollowing(true, transform);

            _rope.SetActive(true);
            _ropeTarget1.transform.position = transform.position + new Vector3(-1.14f, 0f, 0f);
            _ropeTarget2.transform.position = transform.position + new Vector3(1.14f, 0f, 0f);
        }
    }

    private void TranslatePlayerToStartPoint()
    {
        if (_player == null)
            return;

        _player.transform.position = Vector3.Lerp(_player.transform.position, transform.position, _timer);

        _timer += 1.5f * Time.deltaTime;

        if (_timer >= 1f)
        {
            _canTranslatePlayerToStartPoint = false;
            _timer = 0f;
        }
    }
}
