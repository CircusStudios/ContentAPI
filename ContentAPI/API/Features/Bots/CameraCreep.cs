namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class CameraCreep : Bot, IWrapper<Bot_CameraCreep>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CameraCreep"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public CameraCreep(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_CameraCreep bot))
                throw new ArgumentException("Could not find Bot_CameraCreep component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_CameraCreep Base { get; }

        /// <summary>
        /// Attacks the player with a creep attack.
        /// </summary>
        public void Attack() => Base.RPCA_DoCreepAttack(Base.bot.targetPlayer.refs.view.ViewID);

        /// <summary>
        /// Makes the Creep go away.
        /// </summary>
        public void TeleportAway() => Base.TeleportAway();

        /// <summary>
        /// Starts the chase with a player.
        /// </summary>
        /// <param name="player">The player to start the chase.</param>
        public void Chase(Player player) => Base.ChaseTarget(player.Base);
    }
}