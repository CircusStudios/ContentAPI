namespace ContentAPI.API.Features.Bots
{
    using ContentAPI.API.Interface;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Skinny : Bot, IWrapper<Bot_Skinny>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Skinny"/> class.
        /// </summary>
        /// <param name="skinny">The skinny to wrap.</param>
        public Skinny(Bot_Skinny skinny)
            : base(skinny.bot)
        {
            Base = skinny;
        }

        /// <inheritdoc/>
        public new Bot_Skinny Base { get; }

        /// <summary>
        /// Gets a value indicating whether the bot is in the dimension.
        /// </summary>
        public bool IsInDimension => Base.fullyInDimention;

        /// <summary>
        /// Forces the bot to Switch Dimension.
        /// </summary>
        public void SwitchDimension() => Base.DimentionSwitching();

        /// <summary>
        /// Makes the AI exit the dimension.
        /// </summary>
        public void ExitDimension() => Base.ExitDimentionFully();

        /// <summary>
        /// Clears all the targets.
        /// </summary>
        public void ClearTargets() => Base.ClearTargets();

        /// <summary>
        /// Makes the AI stare.
        /// </summary>
        public void Stare() => Base.Stare();

        /// <summary>
        /// Forces the AI to attack.
        /// </summary>
        /// <param name="player">The player to attack.</param>
        public void ForceAttack(Player player) => Base.AttackPlayer(player.Base);

        /// <summary>
        /// Tries to attack the player.
        /// </summary>
        /// <param name="player">The player to target.</param>
        public void TryAttack(Player player) => Base.TryAttackPlayer(player.Base);

        /// <summary>
        /// Makes the AI Fail to attack.
        /// </summary>
        /// <param name="player">The player who attack failed.</param>
        public void FailToAttack(Player player) => Base.FailToAttackPlayer(player.Base);
    }
}