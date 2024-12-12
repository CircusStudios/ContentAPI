namespace ContentAPI.API.Components
{
    using ContentAPI.API.Features;
    using UnityEngine;

    /// <summary>
    /// Custom input handler.
    /// </summary>
    public class CustomInputHandler : MonoBehaviour
    {
        private void Update()
        {
            foreach (CustomInput input in CustomInput.Registered)
            {
                if (!Input.GetKeyDown(input.Key))
                    continue;

                input.ProcessInput();
            }
        }
    }
}