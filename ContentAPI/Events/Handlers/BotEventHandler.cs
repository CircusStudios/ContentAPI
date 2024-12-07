﻿namespace ContentAPI.Events.Handlers
{
    using ContentAPI.Events.EventArgs.Monsters;
    using UnityEngine.Events;

    /// <summary>
    /// Handler for bot events.
    /// </summary>
    public static class BotEventHandler
    {
        /// <summary>
        /// Gets the event for monster being created.
        /// </summary>
        public static UnityEvent<MonsterCreatingEventArgs> MonsterCreating { get; } = new();

        /// <summary>
        /// Gets the event for monster being destroyed.
        /// </summary>
        public static UnityEvent<MonsterDestroyingEventArgs> MonsterDestroying { get; } = new();
    }
}