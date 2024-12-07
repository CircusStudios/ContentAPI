namespace ContentAPI.API.Features.Bots
{
    using ContentAPI.API.Interface;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class CameraCreep : Bot, IWrapper<Bot_CameraCreep>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CameraCreep"/> class.
        /// </summary>
        /// <param name="cameraCreep">The creep to wrap.</param>
        public CameraCreep(Bot_CameraCreep cameraCreep)
            : base(cameraCreep.bot)
        {
            Base = cameraCreep;
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