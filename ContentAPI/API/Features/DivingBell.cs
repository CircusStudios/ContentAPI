namespace ContentAPI.API.Features
{
    using System.Collections.Generic;
    using System.Linq;
    using ContentAPI.API.Enums;

    using ContentAPI.API.Interface;
    using DivingBellAPI = global::DivingBell;

    /// <summary>
    /// Wrapper for the Diving Bell.
    /// </summary>
    public class DivingBell : IWrapper<DivingBellAPI>
    {
        private Dictionary<BellsState, DivingBellState> status;

        /// <summary>
        /// Initializes a new instance of the <see cref="DivingBell"/> class.
        /// </summary>
        /// <param name="divingBell">The Monobehavior for the Diving Bell.</param>
        internal DivingBell(DivingBellAPI divingBell)
        {
            Instance = this;
            Instance.Base = divingBell;
            Instance.status = new()
            {
                [BellsState.Ready] = new DivingBellReadyState(Instance.Base.onSurface),
                [BellsState.NotReady] = new DivingBellNotReadyDoorOpenState(),
                [BellsState.MissingPlayer] = new DivingBellNotReadyMissingPlayersState(),
                [BellsState.Ready] = new DivingBellRechargingState(),
            };

            foreach (DivingBellState type in Instance.status.Values)
            {
                Instance.Base.StateMachine.RegisterState(type);
            }
        }

        /// <summary>
        /// Gets the Current DivingBell.
        /// </summary>
        public static DivingBell Instance { get; private set; }

        /// <inheritdoc/>
        public DivingBellAPI Base { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether the door is Locked.
        /// </summary>
        public bool LockDoor
        {
            get => Base.locked;
            set => Base.locked = value;
        }

        /// <summary>
        /// Gets a value indicating whether the bell is in surface.
        /// </summary>
        public bool IsSurface => Base.onSurface;

        /// <summary>
        /// Gets a value indicating whether the bell is underground.
        /// </summary>
        public bool IsUnderground => !Base.onSurface;

        /// <summary>
        /// Gets or sets the current state of the Bell.
        /// </summary>
        public BellsState State
        {
            get => status.FirstOrDefault(kv => kv.Value == Base.StateMachine.CurrentState).Key;
            set
            {
                if (value == BellsState.Custom)
                    return;

                if (!status.TryGetValue(value, out DivingBellState state))
                    return;

                Base.StateMachine.SwitchState(state.GetType());
            }
        }

        /// <summary>
        /// Close the door.
        /// </summary>
        public void Close() => Base.AttemptSetOpen(false);

        /// <summary>
        /// Opens the door.
        /// </summary>
        public void Open() => Base.AttemptSetOpen(true);

        /// <summary>
        /// Teleports everyone to the Underground.
        /// </summary>
        public void GoUnderGround() => Base.GoUnderground();

        /// <summary>
        /// Teleports everyone to the Surface.
        /// </summary>
        public void GoToSurface() => Base.GoToSurface();

        /// <summary>
        /// Plays the sound of the transition.
        /// </summary>
        public void PlaySound() => Base.sfx.PlayStartTransition();
    }
}