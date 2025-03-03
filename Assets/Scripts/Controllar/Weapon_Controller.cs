using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Controller : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private GameObject _gunPrefab;

    [SerializeField]private List<GameObject> _weapons;

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject gun = Instantiate(_gunPrefab);
            gun.transform.SetParent(_player.transform);
            _weapons.Add(gun);
            
        }
        NewPositionMaker();
    }

    private void NewPositionMaker()
    {
        float angle = (2f * Mathf.PI) / _weapons.Count;

        for (int i = 0;i<_weapons.Count;i++)
        { 
            float x = _player.position.x + Mathf.Cos(angle);
            float y = _player.position.y + Mathf.Sin(angle);

            _weapons[i].transform.position = new Vector3(x,y, _weapons[i].transform.position.y);
            angle += angle;
        }
    }
}
