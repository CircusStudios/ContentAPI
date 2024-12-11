namespace ContentAPI.API.Components
{
    using UnityEngine;

    /// <summary>
    /// CustomKeybind controller.
    /// </summary>
    public class CustomInputHandler : MonoBehaviour
    {
        private void Update()
        {
            foreach (Features.Input input in Features.Input.Registered)
            {
                if (!Input.GetKeyDown(input.Key))
                    continue;

                input.ProcessInput();
            }
        }
    }
}