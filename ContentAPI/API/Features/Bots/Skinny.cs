namespace ContentAPI.API.Features.Bots
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Skinny : Bot
    {
        private global::Bot_Skinny api;

        /// <summary>
        /// Initializes a new instance of the <see cref="Skinny"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Skinny(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Skinny bot))
                throw new ArgumentException("Could not find Bot_Skinny component in GameObject");

            api = bot;
        }

        /// <summary>
        /// Gets a value indicating whether the bot is in the dimension.
        /// </summary>
        public bool IsInDimension => api.fullyInDimention;

        /// <summary>
        /// Forces the bot to Switch Dimension.
        /// </summary>
        public void SwitchDimension() => api.DimentionSwitching();

        /// <summary>
        /// Makes the AI exit the dimension.
        /// </summary>
        public void ExitDimension() => api.ExitDimentionFully();

        /// <summary>
        /// Clears all the targets.
        /// </summary>
        public void ClearTargets() => api.ClearTargets();

        /// <summary>
        /// Makes the AI stare.
        /// </summary>
        public void Stare() => api.Stare();

        /// <summary>
        /// Forces the AI to attack.
        /// </summary>
        /// <param name="player">The player to attack.</param>
        public void ForceAttack(Player player) => api.AttackPlayer(player.Base);

        /// <summary>
        /// Tries to attack the player.
        /// </summary>
        /// <param name="player">The player to target.</param>
        public void TryAttack(Player player) => api.TryAttackPlayer(player.Base);

        /// <summary>
        /// Makes the AI Fail to attack.
        /// </summary>
        /// <param name="player">The player who attack failed.</param>
        public void FailToAttack(Player player) => api.FailToAttackPlayer(player.Base);
    }
}