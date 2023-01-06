// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using UnityEngine;

namespace Watona.Utils.Variables
{
    [CreateAssetMenu]
    public class BooleanVariable : ScriptableObject
    {
        [SerializeField]
        private bool value;

        public bool Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }
}