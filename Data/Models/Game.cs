namespace GameTime.Data.Models
{
    /// <summary>
    /// The base game class.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// The name of the game.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The maximum number of players who can be in a session.
        /// </summary>
        public int MaxPlayers { get; set; }

        /// <summary>
        /// The latform that the game is on
        /// </summary>
        public Platform Platform { get; set; }
    }
}
