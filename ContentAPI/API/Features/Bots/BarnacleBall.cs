namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using Photon.Pun;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class BarnacleBall : Bot, IWrapper<Bot_BarnacleBall>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarnacleBall"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public BarnacleBall(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_BarnacleBall bot))
                throw new ArgumentException("Could not find Bot_BarnacleBall component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_BarnacleBall Base { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the monster is doing the gas.
        /// </summary>
        public bool IsGas
        {
            get => Base.releaseGas;
            set => Base.TrySyncGas(value);
        }

        /// <summary>
        /// Tries to attack.
        /// </summary>
        public void TryAttack() => Base.TryToAttack();

        /// <summary>
        /// Forces the player to do the tentacle to the target.
        /// </summary>
        /// <remarks>You should use SetTarget() before using this.</remarks>
        public void ForceTentacle() => Base.view.RPC("RPCA_DoTentacleAttack", RpcTarget.All, new object[]
        {
            Base.bot.targetPlayer.refs.view.ViewID,
        });
    }
}