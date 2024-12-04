namespace ContentAPI.API.Features.Bots
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Weeping : Bot
    {
        private global::Bot_Weeping api;

        /// <summary>
        /// Initializes a new instance of the <see cref="Weeping"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Weeping(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Weeping bot))
                throw new ArgumentException("Could not find Bot_Weeping component in GameObject");

            api = bot;
        }

        /// <summary>
        /// Gets a value indicating whether the AI has caught someone.
        /// </summary>
        public bool HasCapturedPlayer => api.HasCapturedPlayer;

        /// <summary>
        /// Gets a value indicating whether the player is doing a captcha.
        /// </summary>
        public bool HasPlayerInCaptchaGame => api.HasPlayerInCaptchaGame;

        /// <summary>
        /// Gets point of the capture.
        /// </summary>
        public Vector3 CapturePoint => api.CapturePoint;

        /// <summary>
        /// Gets a value indicating whether checks if the AI has finished the captcha.
        /// </summary>
        public bool IsFinished => api.captchaGameFinished;

        /// <summary>
        /// Gets the player captured.
        /// </summary>
        public Player CapturedPlayer => Player.Get(api.capturedPlayer);

        /// <summary>
        /// Gets the player resolving the captcha.
        /// </summary>
        public Player PlayerResolving => Player.Get(api.playerInCaptchaGame);

        /// <summary>
        /// Reset the AI.
        /// </summary>
        public void Reset() => api.RPCA_RelasePlayerAndRestartCaptchaThings();

        /// <summary>
        /// Forces a player to Join the Captcha.
        /// </summary>
        /// <param name="player">The player forced to join the captcha.</param>
        public void JoinCaptcha(Player player) => api.PlayerInteracted(player.PhotonView);

        /// <summary>
        /// Tries to capture the target.
        /// </summary>
        public void TryCatch() => api.TryCapturePlayer();

        /// <summary>
        /// Makes Weeping Capture a player.
        /// </summary>
        /// <param name="player">The player to capture.</param>
        public void ForceCapture(Player player) => api.RPCA_CapturePlayer(player.PhotonView.ViewID);

        /// <summary>
        /// Makes the AI force the fail.
        /// </summary>
        public void ForceFail() => api.RPCA_CaptchaGameFailed();

        /// <summary>
        /// Makes the AI force win.
        /// </summary>
        public void ForceWin() => api.RPCA_CaptchaGameSuccess();

        /// <summary>
        /// Makes the player doing the captcha leave.
        /// </summary>
        public void LeaveCaptcha() => api.RPCA_LeaveCaptchaGame();

        /// <summary>
        /// Sets the Tries the player has.
        /// </summary>
        /// <param name="fails">How many fails.</param>
        /// <param name="max">Max fails.</param>
        public void SetTries(int fails, float max) => api.capturedCanvas.SetTries(fails, max);

        /// <summary>
        /// Sets the timer for the captcha game.
        /// </summary>
        /// <param name="left">Time left.</param>
        /// <param name="max">Max time.</param>
        public void SetTimer(float left, float max) => api.capturedCanvas.SetGameTimer(left, max);

        /// <summary>
        /// Changes the Progress Bar.
        /// </summary>
        /// <param name="progress">How much progress.</param>
        public void SetProgress(int progress) => api.capturedCanvas.SetProgress(progress);

        /// <summary>
        /// Does the fail shake.
        /// </summary>
        /// <param name="shake">Shakes the monitor.</param>
        public void FailScreen(bool shake = true) => api.capturedCanvas.DoFailStuff(shake);
    }
}