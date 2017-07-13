// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Enums.cs" company="Wolf">
//   Jesús González Gómez
// </copyright>
// <summary>
//   Enumeration definition file
//   for Models namespace
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Models
{
    /// <summary>
    /// Project Color Enumeration
    /// for project priority property.
    /// </summary>
    public enum ProjColor
    {
        /// <summary>
        /// Red: used when Priority is Urgent
        /// </summary>
        Red,

        /// <summary>
        /// Yellow: used when Priority is Mid
        /// </summary>
        Yellow,

        /// <summary>
        /// Green: used when Priority is Soft
        /// </summary>
        Green,

        /// <summary>
        /// Black: used when Priority is Null
        /// </summary>
        Black,

        /// <summary>
        /// White: used when Priority is Done
        /// </summary>
        White
    }

    /// <summary>
    /// Head Up Display Position Enumeration
    /// for the position of the Head Up Display in the Screen.
    /// </summary>
    public enum HudPosition
    {
        /// <summary>
        /// The top.
        /// </summary>
        Top,

        /// <summary>
        /// The right.
        /// </summary>
        Right,

        /// <summary>
        /// The bot.
        /// </summary>
        Bot,

        /// <summary>
        /// The left.
        /// </summary>
        Left
    }

    /// <summary>
    /// Timer Type Enumeration
    /// for setting the desired type of work time duration ratios
    /// </summary>
    public enum PomType
    {
        /// <summary>
        /// Work 25 / cool 5 / long 15 (every 5)
        /// </summary>
        Twenty5,

        /// <summary>
        /// Work 52 / cool 17 / long 0 (every 5)
        /// </summary>
        Fifty2,

        /// <summary>
        /// Defined by user
        /// </summary>
        Custom
    }

    /// <summary>
    /// Head Up Display Order of the Projects
    /// for order the projects in the way you should be working
    /// </summary>
    public enum HudOrder
    {
        /// <summary>
        /// Order by Priority
        /// </summary>
        Color,

        /// <summary>
        /// Order by Date
        /// </summary>
        Date,

        /// <summary>
        /// Order by Hand.
        /// </summary>
        Custom
    }
}
