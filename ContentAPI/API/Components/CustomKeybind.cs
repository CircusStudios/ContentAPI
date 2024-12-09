namespace ContentAPI.API.Monobehavior
{
    using System.Linq;
    using UnityEngine;

    /// <summary>
    /// CustomKeybind controller.
    /// </summary>
    public class CustomKeybind : MonoBehaviour
    {
        private void Update()
        {
            foreach (Features.Input input in Features.Input.Registered.Where(input => Input.GetKeyDown(input.Key)))
                input.ProcessInput();
        }
    }
}