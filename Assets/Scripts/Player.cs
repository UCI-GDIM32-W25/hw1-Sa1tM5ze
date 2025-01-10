using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        //refresh the seed counts when the game starts
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;

        //update the game ui when the game starts
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        //player movements up, down, left, right
        if (Input.GetKey(KeyCode.W))
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }


        //player planting seeds
        if(Input.GetKeyUp(KeyCode.Space))
        {
            //call the plantseed method if there are remaining seeds
            if (_numSeeds > 0)
            {
                PlantSeed();
                _numSeeds--;
                Debug.Log("you have planted one seed! good job solving global warming");
            }
        }
    }

    public void PlantSeed ()
    {
        //increase the num of planted seeds, decrease the num of remaining seeds
        _numSeedsPlanted ++;
        _numSeedsLeft--;
        //call and update the UI
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

        //spawning the seed
        GameObject plant = Instantiate(_plantPrefab, transform.position, transform.rotation);
    }
}
