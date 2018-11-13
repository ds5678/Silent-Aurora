using UnityEngine;

namespace SilentAurora
{
    internal class Implementation
    {
        public static void OnLoad()
        {
            Debug.Log("[Silent-Aurora] Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
        }
    }
}
