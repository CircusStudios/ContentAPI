namespace ContentAPI.API.Features.Bots
{
    using ContentAPI.API.Interface;
    using Photon.Pun;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class BarnacleBall : Bot, IWrapper<Bot_BarnacleBall>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarnacleBall"/> class.
        /// </summary>
        /// <param name="barnacleBall">The barnacle ball to wrap.</param>
        public BarnacleBall(Bot_BarnacleBall barnacleBall)
            : base(barnacleBall.bot)
        {
            Base = barnacleBall;
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