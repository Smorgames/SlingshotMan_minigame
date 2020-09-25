using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    [SerializeField] private SpawnObject[] _level;

    private void Start()
    {
        SpawnLevel(0);
    }

    public void SpawnLevel(float yOffset)
    {
        for (int i = 0; i < _level.Length; i++)
        {
            SpawnOneObject(_level[i], yOffset);

            if (_level[i].Name == "Points")
            {
                SpawnOneObject(_level[i], yOffset);
                SpawnOneObject(_level[i], yOffset);
            }
        }
    }

    private void SpawnOneObject(SpawnObject _object, float yOffset)
    {
        Vector2 spawnPosition = new Vector2(Random.Range(_object.FirstCoordinate.x, _object.SecondCoordinate.x),
        Random.Range(_object.FirstCoordinate.y, _object.SecondCoordinate.y) + yOffset);
        Instantiate(_object.SpawnObj, spawnPosition, Quaternion.identity);
    }
}