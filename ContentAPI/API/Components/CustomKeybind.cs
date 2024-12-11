namespace ContentAPI.API.Components
{
    using System.Linq;
    using UnityEngine;

    /// <summary>
    /// CustomKeybind controller.
    /// </summary>
    public class CustomKeybind : MonoBehaviour
    {
        private void Awake() => DontDestroyOnLoad(gameObject);

        private void Update()
        {
            foreach (Features.Input input in Features.Input.Registered.Where(input => Input.GetKeyDown(input.Key)))
                input.ProcessInput();
        }
    }
}