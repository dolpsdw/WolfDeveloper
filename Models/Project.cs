// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Project.cs" company="Wolf">
//   Jesús González Gómez
// </copyright>
// <summary>
//   Defines the Project type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Models
{
    /// <summary>
    /// Project model definition.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// The internal identifier
        /// for in case DB
        /// </summary>
        private readonly int id;

        /// <summary>
        /// The internal name
        /// for the name detail
        /// </summary>
        private readonly string name;

        /// <summary>
        /// The internal picture
        /// for the url path of the picture
        /// </summary>
        private readonly string imagen;

        /// <summary>
        /// The internal summary
        /// for the description of the project
        /// </summary>
        private readonly string summary;

        /// <summary>
        /// The internal priority
        /// for the urgently of the project
        /// </summary>
        private readonly ProjColor priority;

        /// <summary>
        /// The internal number of timers completed for awareness purposes
        /// </summary>
        private readonly int pomodores;

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// Using UNMUTABLE pattern principles.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="imagen">The picture.</param>
        /// <param name="summary">The summary.</param>
        /// <param name="priority">The priority.</param>
        /// <param name="pomodores">The timers.</param>
        public Project(int id, string name, string imagen, string summary, ProjColor priority, int pomodores)
        {
            this.id = id;
            this.name = name;
            this.imagen = imagen;
            this.summary = summary;
            this.priority = priority;
            this.pomodores = pomodores;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id => this.id;

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name => this.name;

        /// <summary>
        /// Gets the picture.
        /// </summary>
        /// <value>The picture.</value>
        public string Imagen => this.imagen;

        /// <summary>
        /// Gets the summary.
        /// </summary>
        /// <value>The summary.</value>
        public string Summary => this.summary;

        /// <summary>
        /// Gets the priority.
        /// </summary>
        /// <value>The priority.</value>
        public ProjColor Priority => this.priority;

        /// <summary>
        /// Gets the timers.
        /// </summary>
        /// <value>The timers.</value>
        public int Pomodores => this.pomodores;

        #region Funktions

        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name="newName">The new name.</param>
        /// <returns>New Cloned Project with updated Name</returns>
        public Project SetName(string newName)
        {
            return new Project(this.id, newName, this.imagen, this.summary, this.priority, this.pomodores);
        }

        /// <summary>
        /// Sets the picture.
        /// </summary>
        /// <param name="newImagen">The new picture URL.</param>
        /// <returns>New Cloned Project with updated Picture.</returns>
        public Project SetImagen(string newImagen)
        {
            return new Project(this.id, this.name, newImagen, this.summary, this.priority, this.pomodores);
        }

        /// <summary>
        /// Sets the summary.
        /// </summary>
        /// <param name="newSummary">The new summary.</param>
        /// <returns>New Cloned Project with updated Summary.</returns>
        public Project SetSummary(string newSummary)
        {
            return new Project(this.id, this.Name, this.imagen, newSummary, this.priority, this.pomodores);
        }

        /// <summary>
        /// Sets the priority.
        /// </summary>
        /// <param name="newPriority">The new priority.</param>
        /// <returns>New Cloned Project with updated Priority.</returns>
        public Project SetPriority(ProjColor newPriority)
        {
            return new Project(this.id, this.Name, this.imagen, this.summary, newPriority, this.pomodores);
        }

        /// <summary>
        /// Sets the number of timers associated with the project.
        /// </summary>
        /// <param name="newPomodores">The new number of timers.</param>
        /// <returns>New Cloned Project with updated numbers of timers.</returns>
        public Project SetPomodores(int newPomodores)
        {
            return new Project(this.id, this.Name, this.imagen, this.summary, this.priority, newPomodores);
        }

        #endregion
    }
}
