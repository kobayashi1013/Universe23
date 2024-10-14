using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectManager
{
    public class ObjectManager : MonoBehaviour
    {
        private enum CollectionMethod
        {
            Collect,
            Call
        }

        [SerializeField] private CollectionMethod _collectionMethod;

        private void Start()
        {
            if (_collectionMethod == CollectionMethod.Collect)
            {
                var managedObjects = FindObjectsOfType<CollectObject>();
            }            
        }
    }
}
