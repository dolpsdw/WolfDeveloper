// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="Wolf">
//   Jesús González Gómez
// </copyright>
// <summary>
//   Pomodore Application for Developers
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WolfDeveloper
{
    using System.Windows;

    /// <summary>
    /// Main Windows
    /// </summary>
    public partial class MainWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();

            // Lateral proportions
            this.Height = 600;
            this.Width = 66;

            // Top Down proportions
            // this.Height = 66;
            // this.Width = 600;

            /*TODO:
             * Load from persitance Settings the 4 type of HUD Top Right Bottom Left
             * Load from peristance Setting if the grid is Movable
             *       if Movable, Load from Settings the last XY coordinates
             * 
             * Initialize the HUD in acordance with Settings, default Left NonMovable
             */
            this.Left = 0; // (SystemParameters.PrimaryScreenWidth - this.Width) / 2;
            this.Top = (SystemParameters.PrimaryScreenHeight - this.Height) / 2;
        }
    }
}
