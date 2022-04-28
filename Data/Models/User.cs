namespace GameTime.Data.Models
{
    /// <summary>
    /// The base user class.
    /// </summary>
    public class User
    {
        /// <summary>
        /// The user's email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The user's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The user's hashed password.
        /// </summary>
        public string Password { get; set; }
    }
}
