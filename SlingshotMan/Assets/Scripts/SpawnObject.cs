using UnityEngine;
using System;

[Serializable]
public class SpawnObject
{
    [SerializeField] private string _name;

    [SerializeField] private GameObject _spawnObject;
    [SerializeField] private Vector2 _firstCoordinate;
    [SerializeField] private Vector2 _secondCoordinate;

    public SpawnObject(GameObject spawnObject, Vector2 firstCoordinate, Vector2 secondCoordinate)
    {
        _spawnObject = spawnObject;
        _firstCoordinate = firstCoordinate;
        _secondCoordinate = secondCoordinate;
    }

    public string Name
    {
        get { return _name; }
    }

    public GameObject SpawnObj
    {
        set { _spawnObject = value; }
        get { return _spawnObject;  }
    }

    public Vector2 FirstCoordinate
    {
        set { _firstCoordinate = value; }
        get { return _firstCoordinate; }
    }

    public Vector2 SecondCoordinate
    {
        set { _secondCoordinate = value; }
        get { return _secondCoordinate; }
    }

    //public void InstansiateObject()
    //{
    //    Instantiate(_spawnObject, new Vector2(UnityEngine.Random.Range(_firstCoordinate.x, _secondCoordinate.x),
    //    UnityEngine.Random.Range(_firstCoordinate.y, _secondCoordinate.y) + transform.position.y), Quaternion.identity);
    //}
}
